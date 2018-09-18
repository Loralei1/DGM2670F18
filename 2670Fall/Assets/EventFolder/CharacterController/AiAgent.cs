using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Experimental.PlayerLoop;

[RequireComponent(typeof(NavMeshAgent))]
public class AiAgent : MonoBehaviour
{

    private NavMeshAgent agent;
    public Transform Destination;
    //public bool CanChase;
    public Transform postpoint;
    private Transform finalDestination;
    
    private void Start()

    {
        agent = GetComponent<NavMeshAgent>();
        finalDestination = transform;
    }

    private void OnTriggerEnter(Collider obj)
    {
       if(obj.transform == Destination)
        finalDestination = Destination;
        //CanChase = true;
    }

    private void OnTriggerExit(Collider other)
    {
        finalDestination = postpoint;
        //CanChase = false;
    }

    private void Update()
    {
        
        {
            agent.destination = finalDestination.position;
        }
        
       
    }

    
        
    
}

