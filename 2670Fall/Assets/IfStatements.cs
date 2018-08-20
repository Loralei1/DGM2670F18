using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

	public int Score;
	public float Speed;
	public bool LightsOn;

	// Use this for initialization
	void Start ()
	{
		if (true)
		{
			//do work
		}

		if (Score == 10)
		{
			print("Ten");
		}

		if (Speed >= 4)
		{
			print("Gotta go fast!");
		}

		if (!LightsOn && Speed > 4)
		{
			print("Lights out.");
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
