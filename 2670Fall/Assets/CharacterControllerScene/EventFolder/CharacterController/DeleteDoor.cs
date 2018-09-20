using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteDoor : MonoBehaviour {

	void OnTriggerEnter (Collider other) 

	{

		if (other.gameObject.CompareTag ("Door"))

		{

			other.gameObject.SetActive(false);

		}



	}


}
