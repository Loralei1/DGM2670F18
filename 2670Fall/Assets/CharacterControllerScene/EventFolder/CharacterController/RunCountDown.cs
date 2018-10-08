using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunCountDown : MonoBehaviour {

	private Text label;
	public float seconds = 1.0f;
	public int number = 3; 
	
	
	IEnumerator Start()
	{
		label = GetComponent<Text>();
		while (number > 0)
		{
			yield return new WaitForSeconds(seconds);
			label.text = number.ToString();
			number--;
			
		}
		yield return new WaitForSeconds(1);
		label.text = "Go!";

	}
}
