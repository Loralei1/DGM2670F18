using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

	public FloatValue FloatValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (FloatValue.Value == 0)
		{
			gameObject.SetActive(false);
		}
		
	}
}
