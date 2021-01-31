// this script has to be attached to a game object for the log console to change
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // I can add new components to the code that's not inside the Start or Updates classes
    int myInt = 25;

    // Start is called before the first frame update
    // when the game begins, this happens 
    void Start()
    {
        // update my int by the new one that I got from the function
        myInt = MultiplyByFive(myInt);
        // display the answer in the Unity Log viewer
        Debug.Log(myInt);
    }

    // the function takes in a number and returns a new one
    // the name of the int doesn't have to be the same as the oen passed in
    int MultiplyByFive(int n)
    {
        // basically, create a new int, store answer in variable when done multiplying, then spit it out
        int r;
        r = n * 5;
        return r;
    }
}