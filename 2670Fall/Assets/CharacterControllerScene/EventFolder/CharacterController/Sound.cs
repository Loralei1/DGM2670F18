using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

	public AudioSource audiosource;
	
	void Update () 

	{

		while (Input.GetButton ("Horizontal") == false) 

		{

			audiosource.Play ();

			break;

		}



	}
}
