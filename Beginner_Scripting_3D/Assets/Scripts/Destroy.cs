using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject obj;
    void Update()
    {
        // if you don't create a targeted game object, the object and the script would both be deleted
        // since the script is attached to it
        if (Input.GetKey(KeyCode.Space))
            // adding a number after gives a timer
            Destroy(obj, 3f);
        //if (Input.GetKey(KeyCode.Space))
            //Destroy(GetComponent<MeshRenderer>());
    }
}
