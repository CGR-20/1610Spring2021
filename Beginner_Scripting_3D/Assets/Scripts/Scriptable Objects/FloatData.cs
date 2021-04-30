using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Float Data", menuName = "Float Data")]
public class FloatData : ScriptableObject
{
    public float value;

    public void ReplaceFloat(float number)
    {
        value = number;
    }

    public void DisplayFloat()
    {
        Debug.Log(value);
    }
}
