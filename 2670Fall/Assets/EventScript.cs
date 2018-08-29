using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventScript : MonoBehaviour
{

    public UnityEvent MyEvent;
    public UnityEvent Event;
    public UnityEvent AnEvent;
    public UnityEvent WordEvent;
    public UnityEvent JumpEvent;

    private void Start()
    {
        MyEvent.Invoke();
    }

    private void OnMouseDown()
    
        {
          Event.Invoke();  
        }

    private void OnTriggerEnter(Collider other)
    {
        AnEvent.Invoke();
    }

    private void OnMouseOver()
    {
        WordEvent.Invoke();
    }

    private void OnMouseExit()
    {
        JumpEvent.Invoke();
    }

    /*private void OnMouseDown()
    {
        Event.Invoke();
    }*/
}
