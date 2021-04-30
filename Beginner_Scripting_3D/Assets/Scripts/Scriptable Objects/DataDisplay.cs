using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataDisplay : MonoBehaviour
{
    public IntData myInt;
    public FloatData myFloat;
    public Vector3Data myVector;

    void Start()
    {
        myFloat.DisplayFloat();
        myFloat.ReplaceFloat(7.95f);
        myFloat.DisplayFloat();

        myVector.PrintVector();
        //myVector.NewVector(new Vector3(2, 4, 3));
        //myVector.PrintVector();
    }


    void Update()
    {
        myInt.DisplayInt();
        myInt.AddToInt(Random.Range(0, 100));
    }
}
