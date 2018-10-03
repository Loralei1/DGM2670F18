using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{

	public NameID ID;
	public UnityEvent OnMatch;

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


