using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventScript : MonoBehaviour
{

    public UnityEvent MyEvent;
    public UnityEvent Event;

    private void Start()
    {
        MyEvent.Invoke();
    }

    private void OnMouseDown()
    
        {
          Event.Invoke();  
        }
   

    

    /*private void OnMouseDown()
    {
        Event.Invoke();
    }*/
}
