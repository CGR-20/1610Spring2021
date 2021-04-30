using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent; // create event to pass object to

    private void OnTriggerEnter(Collider other) // when the attached object enters trigger
    {
        triggerEnterEvent.Invoke(); // activate the event
    }
}
