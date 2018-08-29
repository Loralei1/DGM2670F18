using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoarEvents : MonoBehaviour
{

	public UnityEvent NewEvent;

	public UnityEvent OnEvent;
	public UnityEvent ParticleEvent;
	//Events are not dependent on other scripts
	//Objects, functions, and variables can be referenced/called by an Event
	//Function(){do stuff}; Unity event is a function with no body. 
	//Class UnityEvent; Invoke(){Code visualized by unity};
	private void OnMouseOver()
	{
		NewEvent.Invoke();                                                                       
	}

	private void OnMouseExit()
	{
		OnEvent.Invoke();
	}

	private void OnMouseDown()
	{
		ParticleEvent.Invoke();
	}
}
