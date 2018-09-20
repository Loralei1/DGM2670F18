using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveExample : MonoBehaviour
{

	private CharacterController controller;
	public MovePattern MovePattern;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	//Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"
	void Update()
	{

		MovePattern.Invoke(controller, transform);


	}
}