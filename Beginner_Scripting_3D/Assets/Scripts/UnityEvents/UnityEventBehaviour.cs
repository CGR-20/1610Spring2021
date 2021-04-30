using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventBehaviour : MonoBehaviour
{
    public UnityEvent myEvent; // create event to pass object to

    private void Update() // when the player presses space, trigger event
    {
        if (Input.GetKeyDown(KeyCode.Space))
            myEvent.Invoke(); // activate the event
    }
}
