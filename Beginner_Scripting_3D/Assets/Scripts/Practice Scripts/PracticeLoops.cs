using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeLoops : MonoBehaviour
{
    int counter = 0;
    void Start()
    {
        while (counter < 5)
        {
            print("Counter is at: " + counter);
            counter++;
        }
    }
}
