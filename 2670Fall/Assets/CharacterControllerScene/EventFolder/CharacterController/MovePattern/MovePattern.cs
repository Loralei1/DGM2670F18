﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject
{

	//public float speed = 6.0F;
	public FloatData jumpSpeed;
	public FloatData gravity;

	public FloatData MoveX, MoveY, MoveZ;
	public FloatData RotX, RotY, RotZ;


	protected Vector3 moveDirection;
	private Vector3 rotDirection;

	public virtual void Invoke(CharacterController controller, Transform transform)
	{
		if (controller.isGrounded)
		{
			
			Move(transform);//moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
			//rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
			//transform.Rotate(rotDirection);
			//moveDirection = transform.TransformDirection(moveDirection);
			//moveDirection *= speed;
			//if (Input.GetButton("Jump"))
			//{
				//moveDirection.y = jumpSpeed.Value;
			//}
		}

		FinalMove(controller);
	}

	protected void FinalMove(CharacterController controller)
	{
		moveDirection.y = gravity.Value;// * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}

	protected void Move(Transform transform)
	{
		moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
		rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
		transform.Rotate(rotDirection);
		moveDirection = transform.TransformDirection(moveDirection);
	}
}

