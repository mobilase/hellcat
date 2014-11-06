﻿using UnityEngine;
using System.Collections;

public class Object_Treasure : MonoBehaviour 
{
	public int TimeToWaitOnTreasureFound = 1;

	private GameObject MainCamera;
	private float TimeWaitStarted = 0;
	private bool TreasureTriggered = false;
	private Vector3 cameraStartPosition;

	// При запуске
	void Start() 
	{
		// Поиск камеры на сцене
		MainCamera = GameObject.Find("Camera");
	}

	// При обновлении сцены
	void Update () 
	{
		if (TreasureTriggered == true) 
		{
			MainCamera.transform.LookAt(transform.position);
			if (TimeWaitStarted == 0)
			{
				cameraStartPosition = MainCamera.transform.position;
				MainCamera.BroadcastMessage("SetFollowPlayer", false);
				TimeWaitStarted = Time.time;
				audio.Play();
				return;
			}
			float fracPassed = (Time.time - TimeWaitStarted)/TimeToWaitOnTreasureFound;
			camera.transform.position = Vector3.Lerp(cameraStartPosition, new Vector3(transform.position.x, transform.position.y + 5, transform.position.z), fracPassed);
			if (((Time.time - TimeWaitStarted) > TimeToWaitOnTreasureFound)&&(audio.isPlaying == false))
			{
				TreasureTriggered = false;
				Application.LoadLevel("Game_Over");
			}
		}
	}

	// При столкновении
	void OnTriggerEnter(Collider Trigger)
	{
		// Если сундука коснулся воин - загрузить экран проигрыша
		if (Trigger.collider.tag == "Enemy_Warrior") 
		{
			TreasureTriggered = true;
		}
	}
}