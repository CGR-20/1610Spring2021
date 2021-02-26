using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeLoops : MonoBehaviour
{
    int counter = 0;
    string[] names = { "Carlos", "Steve", "Alex" };
    int[] numList = new int[5];
    void Start()
    {
        /*
        while (counter < 5)
        {
            print("Counter is at: " + counter);
            counter++;
        }

        foreach (string i in names)
            print("Hello, my name is " + i);
        */

        for (int i = 0; i < 5; i++)
            numList[i] = i;

        foreach (int i in numList)
            print(numList[i]);
    }
}
