using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject myObject;
    void Start()
    {
        // this is before the object is deactivated
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy: " + myObject.activeInHierarchy);

        // deactivate object
        // note that child objects remain inactive if its parent is inactive
        gameObject.SetActive(false);

        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy: " + myObject.activeInHierarchy);
    }
}
