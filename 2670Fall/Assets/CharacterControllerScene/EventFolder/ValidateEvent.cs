using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ValidateEvent : MonoBehaviour
{

	public UnityEvent Event;

	private void OnValidate()
	{
		Event.Invoke();
	}
}
