using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeLoops : MonoBehaviour
{
    int counter = 0;
    string[] names = { "Carlos", "Steve", "Alex" };
    void Start()
    {
        while (counter < 5)
        {
            print("Counter is at: " + counter);
            counter++;
        }

        foreach (string i in names)
            print("Hello, my name is " + i);
    }
}
