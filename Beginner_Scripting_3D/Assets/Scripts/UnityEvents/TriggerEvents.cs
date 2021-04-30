using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    // this script is attached to the thing we want to trigger
    // the actual game object is handled by a object manager

    [SerializeField] private UnityEvent myTrigger;

    private void OnTriggerEnter(Collider other) // still a trigger event
    {
        myTrigger.Invoke(); // will call upon whatever event/script is passed in when triggered
    }
}