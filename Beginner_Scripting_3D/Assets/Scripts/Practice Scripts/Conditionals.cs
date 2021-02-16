using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    void Start()
    {
        int x = 50;
        int y = 10;

        if (x > y)
            Debug.Log("Hello World");
        else if (x < y)
            Debug.Log("What's Up World?");
        else
            Debug.Log("Goodbye World");
    }
}
