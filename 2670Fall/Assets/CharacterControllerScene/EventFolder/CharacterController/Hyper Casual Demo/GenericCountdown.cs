using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.Events;

public class GenericCountdown : MonoBehaviour
{

	public UnityEvent OnCount;

	public int numbers = 30;
	public float seconds = 2.0f;

	IEnumerator Start()

	{
		while (numbers > 0)
			OnCount.Invoke();
		yield return new WaitForSeconds(seconds);
		
	}
}
