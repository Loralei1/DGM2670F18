using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.Events;

public class GroundDrag : MonoBehaviour
{

	public bool drag = false;
	public Vector2 Position;
	//public UnityEvent dragBegin;

	//public bool Drag
	//{
	//	get { return drag; }
	//}

	//public UnityEvent DragBegin
	//{
	//	get { return dragBegin; }
	//	set { dragBegin = value; }
	//}

	private void OnMouseDown()
	{
		Position = gameObject.transform.position;
		drag = true;
	}

	public void OnMouseDrag()
	{
		transform.position = Input.mousePosition;
	}

	/*public GameObject Ground;

	private Vector2 GroundButton;

	public void OnMouseDown()
	{
		GetComponent<Vector2>();
	}

	public void OnMouseDrag()
	{
		Vector2 GroundButton = new Vector2(Input.mousePosition.x, Input.mousePosition.y); 
		
		//somehow allow the player to create and or draw the ground
		//add a collider to the drawn ground so that the player can run on it.
		//add button on the ground so the player has something to click on. 
		//what if...I made the basic ground object super thin, so that it when the prefab is instantiated it looks like a 
		//fluid line, but it really a whole lot of little platforms?
		//and then something to destroy the ground prefab when it gets out of range
	}*/

	/*[RequireComponent(typeof(BoxCollider2D))]

	public class Drag : MonoBehaviour {
		private Vector3 screenPoint;
		private Vector3 offset;

		void OnMouseDown() {

			offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		}

		void OnMouseDrag()
		{
			Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
			transform.position = curPosition;
		}
	}*/
}
