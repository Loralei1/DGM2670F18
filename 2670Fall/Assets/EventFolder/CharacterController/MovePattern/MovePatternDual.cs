using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovePatternDual : MovePattern
{

	private bool doubleJump; 
	
	public override void Invoke (CharacterController controller, Transform transform)
	{
		
		if (controller.isGrounded)
		{
			Move(transform);
			doubleJump = true; 

		}
		else
		{
			if (doubleJump)
			{
				moveDirection.y = MoveY.Value;
				doubleJump = false;
			}
		}
		
		FinalMove(controller);
	}
}
