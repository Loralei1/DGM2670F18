using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Disable : MonoBehaviour
{

	public UnityEvent Event;

	private void OnDisable()
	{
		Event.Invoke();
	}
}
