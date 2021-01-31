// make sure to use the correct libraries before doing anything
// they're usually added when creating a new script, but be careful
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MonoBehavior is a class that specifically states that the script is meant for Unity
public class Scripts : MonoBehaviour
{
    // Update is called once per frame
    // basically, it updates the game whenever the player does something
    void Update()
    {
        // if the button pushed is R, do this
        if (Input.GetKeyDown(KeyCode.R))
        {
            // changes color of specified component to red when R is pushed down
            GetComponent<Renderer>().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
