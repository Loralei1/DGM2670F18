using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseDrag : MonoBehaviour
{

	public UnityEvent Event;

	private void OnMouseDrag()
	{
		Event.Invoke();
	}
}
