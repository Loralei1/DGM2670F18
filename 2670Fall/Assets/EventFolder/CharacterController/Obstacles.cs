using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

	public List<GameObject> Enemies; 

	public int HitsTaken; 

	public GameObject other;

	public GameObject AddMember;



	void Start () 



	{

		HitsTaken = 0;

	}



	private void OnTriggerEnter(Collider other)

	{

		if (other.gameObject.CompareTag ("Rock")) {

			Enemies.Add (AddMember.gameObject);

			foreach (GameObject enemy in Enemies)

				HitsTaken += 1;

		}

			

	}


}
