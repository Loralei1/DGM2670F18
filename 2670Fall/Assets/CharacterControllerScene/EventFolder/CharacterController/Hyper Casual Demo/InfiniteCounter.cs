using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InfiniteCounter : MonoBehaviour
{

	public UnityEvent OnCounter; 
	public float Seconds = 1;

	IEnumerator Start()
	{
		while (true)
		{
			OnCounter.Invoke();
			yield return new WaitForSeconds(Seconds);
		}
	}
}
