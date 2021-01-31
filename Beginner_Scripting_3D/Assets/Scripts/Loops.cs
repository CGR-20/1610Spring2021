using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        // int still refers to whole numbers
        int enemies= 3;
        int cups = 4;

        // bool is about true and false values, yes and no, stuff like that
        bool cont = false;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            forLoop(enemies);
        }     

        else if (Input.GetKeyDown(KeyCode.X))
        {
            whileLoop(cups);
        }
            
        else if (Input.GetKeyDown(KeyCode.C))
        {
            doLoop(cont);
        }
            
        else if (Input.GetKeyDown(KeyCode.V))
        {
            eachLoop();
        }
    }

    void forLoop(int e)
    {
        // for loop counts up to specified value one at a time (usually), doing a similar task each increment
        for (int i = 0; i < e; i++)
            // you can add updated variables to output messages by using the + sign
            Debug.Log("Creating enemy number: " + i);
    }

    void whileLoop(int c)
    {
        // similar to for loop, but without specified increment
        while (c > 0)
        {
            Debug.Log("I've washed a cup!");
            // if this wasn't added, it would go on forever
            c--;
        }
    }

    void doLoop (bool c)
    {
        // do while is similar to the others, except it does the execution before it checks to do it again
        do
        {
            print("Hello World");
        // since c is always false, it should only display the message once
        } while (c == true);
    }

    // I would have passed in a string array, but I decided it wasn't worth the debugging
    void eachLoop ()
    {
        // string refers to strings of characters, aka sentences w/wo spaces
        // in particular, we're using an array of strings, meaning multiple strings grouped together in a link
        string[] strings = new string[3];

        // we're able to fill in spaces in an array by calling on the array's name and position
        // it always starts at 0
        strings[0] = "First String";
        strings[1] = "Second String";
        strings[2] = "Third String";

        // again, similar to other loops, but does each item in order within a array
        foreach (string item in strings)
        {
            print(item);
        }
    }
}