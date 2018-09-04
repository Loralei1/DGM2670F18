using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ParticleTriggerEvent : MonoBehaviour
{

	public UnityEvent Event;

	private void OnParticleTrigger()
	{
		Event.Invoke();
	}
}
