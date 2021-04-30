using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Int Data", menuName = "Int Data")]
public class IntData : ScriptableObject
{
    public int value;

    public void AddToInt(int number)
    {
        value += number;
    }

    public void DisplayInt()
    {
        Debug.Log(value);
    }
}
