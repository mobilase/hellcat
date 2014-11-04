﻿using UnityEngine;
using System.Collections;

public class Object_Tree : MonoBehaviour {
	
	private int Random_Value = 0;                 	//случайное число для выбора дерева из списка
	private float Random_Value_Scale = 0.0f;      	//случайное число для создания различной величины деревьев
	private float Warrior_Height = 2.2f; //2.2f   	//высота воина. высота дерева задана в пропорции от высоты воина
	private float Percents_Of_Warrior_Height = 0.2f;//процент от высоты воина для отклоения размера дерева

	//глобальные переменные для рабты с деревьями
	public MeshFilter   Tree_Mesh_Filter;
	public Animator     Tree_Animator;
	public Transform    Tree_Transform;
	public BoxCollider  Tree_Box_Collider;


	public MeshRenderer Tree_Mesh_Renderer;
	public Material    Tree_Material_1;
	public Material    Tree_Material_2;
	public Material    Tree_Material_3;
	public Material    Tree_Material_4;

	//модели конкретных деревьев
	public Mesh Tree_Model_1;
	public Mesh Tree_Model_2;
	public Mesh Tree_Model_3;
	public Mesh Tree_Model_4;
	
	public Avatar Tree_Animation_1;
	public Avatar Tree_Animation_2;
	public Avatar Tree_Animation_3;
	public Avatar Tree_Animation_4;
	
	// задание начальных значнией
	void Start() 
	{
		//получение доступа к объекту с моделями в дереве
		Tree_Mesh_Filter = GetComponent<MeshFilter>();
		Tree_Animator = GetComponent<Animator>();
		Tree_Mesh_Renderer = GetComponent<MeshRenderer>();
		//получение слуайного значения
		Random_Value = Random.Range(1,5);
		Random_Value_Scale = 2 * Warrior_Height + Random.Range(-Percents_Of_Warrior_Height * Warrior_Height,
		                                                       Percents_Of_Warrior_Height * Warrior_Height);
		Tree_Box_Collider.size = new Vector3 (0.25f, 0.25f, 0.5f);


		//первый тип дерева
		if (Random_Value == 1)
		{
			Tree_Mesh_Filter.mesh = Tree_Model_1;
			Tree_Animator.avatar = Tree_Animation_1; 
			Tree_Mesh_Renderer.material = Tree_Material_1;
			Tree_Transform.localScale = new Vector3(Random_Value_Scale, Random_Value_Scale, Random_Value_Scale); 
			Tree_Transform.rotation = Quaternion.AngleAxis(90, Vector3.left); 
			//Tree_Box_Collider.size = new Vector3(1f, 1f, 1);
			//Tree_Transform.position = Tree_Transform.position - new Vector3(0, 0.5f, 0);			
		}

		//второй тип дерева
		if (Random_Value == 2)
		{
			Tree_Mesh_Filter.mesh = Tree_Model_2;
			Tree_Animator.avatar = Tree_Animation_2;
			Tree_Mesh_Renderer.material = Tree_Material_2;
			Tree_Transform.localScale = new Vector3(Random_Value_Scale, Random_Value_Scale, Random_Value_Scale); 
			Tree_Transform.rotation = Quaternion.AngleAxis(90, Vector3.left); 
			//Tree_Box_Collider.size = new Vector3(1f, 1f, 1);
			//Tree_Transform.position = Tree_Transform.position - new Vector3(0, 0.5f, 0);
		}
		
		//третий тип дерева
		if (Random_Value == 3)
		{			
			Tree_Mesh_Filter.mesh = Tree_Model_3;
			Tree_Animator.avatar = Tree_Animation_3;
			Tree_Mesh_Renderer.material = Tree_Material_3;
			Tree_Transform.localScale = new Vector3(Random_Value_Scale, Random_Value_Scale, Random_Value_Scale); 
			Tree_Transform.rotation = Quaternion.AngleAxis(90, Vector3.left); 
			//Tree_Box_Collider.size = new Vector3(1f, 1f, 1);
			//Tree_Transform.position = Tree_Transform.position - new Vector3(0, 0.5f, 0);
		}
		
		//четвертый тип дерева
		if (Random_Value == 4)
		{
			Tree_Mesh_Filter.mesh = Tree_Model_4;
			Tree_Mesh_Renderer.material = Tree_Material_4;
			Tree_Animator.avatar = Tree_Animation_4;
			Tree_Transform.localScale = new Vector3(Random_Value_Scale/3, Random_Value_Scale/3, Random_Value_Scale/3); 
			Tree_Transform.rotation = Quaternion.AngleAxis(90, Vector3.left); 
			//Tree_Box_Collider.size = new Vector3(1f, 1f, 1);
			//Tree_Transform.position = Tree_Transform.position - new Vector3(0, 0.5f, 0);
		}
	}
}
