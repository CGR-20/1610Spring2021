using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    // Note that GetKey refers to already specified Key mapped names (i.e. space = jump)
    // GetKeyDown is when the Key is being pushed down
    // GetKey is where the Key is held down
    // GetKeyUp is when the Key is returning to its original position
    // the return value is boolean, and is during the first frame

    bool down;
    bool held;
    bool up;
    void Update()
    {
        down = Input.GetKeyDown("Jump");
        held = Input.GetKey("Jump");
        up = Input.GetKeyUp("Jump");

        if (down)
            Debug.Log("down value is: " + down);
        if (held)
            Debug.Log("down value is: " + held);
        if (up)
            Debug.Log("down value is: " + up);
    }
}