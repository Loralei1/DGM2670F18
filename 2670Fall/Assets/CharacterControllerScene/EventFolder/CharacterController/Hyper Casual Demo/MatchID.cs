using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class MatchID : MonoBehaviour
{

	public NameID ID;
	public UnityEvent OnMatch;

	private void OnTriggerEnter(Collider other)
	{
		Type ObjectID;
		//var id = other.GetComponent(ObjectID).ID;
		Call(ID);
	}

	private void Call(NameID id)
	{
		throw new NotImplementedException();
	}

	public void Invoke(NameID id)

	{
		if (id == ID)
		{
			OnMatch.Invoke();
		}
	}
	
}

public class NameID
{
}


