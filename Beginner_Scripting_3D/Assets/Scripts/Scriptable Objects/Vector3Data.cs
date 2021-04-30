using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Vector3 Data", menuName = "Vector3 Data")]
public class Vector3Data : ScriptableObject
{
    public Vector3 myVector;

    public void NewVector(Vector3 updatedVector)
    {
        myVector += updatedVector;
    }

    public void PrintVector()
    {
        Debug.Log(myVector);
    }
}
