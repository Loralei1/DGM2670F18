using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{

	private GameObject other;

	public int Points;

	public Text PointText;

	private void Start()
	{
		PointText.text = "1";
	}

	public void OnTriggerEnter(Collider other)
	{
		if (CompareTag("Player"))
		{
			gameObject.SetActive(false);
			Points = Points++; 
		}

		 
		
		
	}

	
	
	
}
