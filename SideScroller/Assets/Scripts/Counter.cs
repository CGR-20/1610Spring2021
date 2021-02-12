using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int creditValue = 3;
    public int numberCount;
    public Text counterText;

    void OnTriggerEnter2D() // physics based function
    {
        numberCount += creditValue;
        counterText.text = numberCount.ToString();
        gameObject.SetActive(false); // collects object once
    }
}
