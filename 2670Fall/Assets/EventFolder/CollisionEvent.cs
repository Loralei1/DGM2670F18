using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour
{

	public UnityEvent Event;

	private void OnCollisionEnter(Collision other)
	{
		Event.Invoke();
	}
}
