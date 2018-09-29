using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class GroundDrag : MonoBehaviour
{

	public GameObject Ground;

	private void OnMouseDrag()
	{
		//somehow allow the player to create and or draw the ground
		//add a collider to the drawn ground so that the player can run on it.
		//add button on the ground so the player has something to click on. 
		//what if...I made the basic ground object super thin, so that it when the prefab is instantiated it looks like a 
		//fluid line, but it really a whole lot of little platforms?
		//and then something to destroy the ground prefab when it gets out of range
	}
}
