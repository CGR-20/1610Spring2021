using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // without UnityEvents, the code would look like this
    // the code would be attached to an object, and effects another
    [SerializeField] private GameObject myObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            myObject.SetActive(true);
    }
}
