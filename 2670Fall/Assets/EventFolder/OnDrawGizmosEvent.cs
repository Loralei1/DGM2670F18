using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnDrawGizmosEvent : MonoBehaviour
{

	public UnityEvent Event;

	private void OnDrawGizmos()
	{
		Event.Invoke();
	}
}
