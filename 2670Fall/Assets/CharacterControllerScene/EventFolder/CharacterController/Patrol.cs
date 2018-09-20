using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour {

	public Transform[] PatrolPoints;

	private int destPoint = 0;

	private NavMeshAgent patroller;


	void Start () {



		patroller = GetComponent<NavMeshAgent> ();

		patroller.autoBraking = false;

		GoToNextPoint ();

		

	}



	void GoToNextPoint ()

	{

		patroller.destination = PatrolPoints[destPoint].position;

		destPoint = (destPoint + 1) % PatrolPoints.Length;

	}

	// Update is called once per frame

	void Update () 

	{

		if (!patroller.pathPending && patroller.remainingDistance < 0.5f) 

		{

			GoToNextPoint();

		}

		

	}

}

