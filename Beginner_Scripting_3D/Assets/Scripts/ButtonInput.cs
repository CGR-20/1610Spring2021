using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInput : MonoBehaviour
{
    // Note that GetButton refers to already specified button mapped names (i.e. space = jump)
    // GetButtonDown is when the button is being pushed down
    // GetButton is where the button is held down
    // GetButtonUp is when the button is returning to its original position
    // the return value is boolean, and is during the first frame

    bool down;
    bool held;
    bool up;
    void Update()
    {
        down = Input.GetButtonDown("Jump");
        held = Input.GetButton("Jump");
        up = Input.GetButtonUp("Jump");

        if (down)
            Debug.Log("down value is: " + down);
        if (held)
            Debug.Log("down value is: " + held);
        if (up)
            Debug.Log("down value is: " + up);
    }
}