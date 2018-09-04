using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BecomeInvisibleEvent : MonoBehaviour
{

	public UnityEvent Event;

	private void OnBecameInvisible()
	{
		Event.Invoke();
	}
}
