using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAccess : MonoBehaviour
{
    // this int is public, so any other script can use it
    public int alpha = 5;

    // these ints are private, only this script and class can use them
    private int beta = 0;
    private int gamma = 5;

    // calls on another script's class
    private AnotherClass myOtherClass;


    void Start()
    {
        alpha = 29;
        // defines a new object tied to a specified class in another script
        myOtherClass = new AnotherClass();
        myOtherClass.Fruitmachine(alpha, myOtherClass.apples); // it goes into a loop, but you get it
    }


    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }


    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
