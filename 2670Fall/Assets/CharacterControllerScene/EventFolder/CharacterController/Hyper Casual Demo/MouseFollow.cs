using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
	public Vector3 tempPos; 
	
	
	private void Update()
	{
		//transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		tempPos = Input.mousePosition;
		tempPos.z = 0;
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition)*5;
		print(Camera.main.ScreenToViewportPoint(tempPos));
	}
}
