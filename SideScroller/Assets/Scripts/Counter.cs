using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int creditValue = 3;
    public IntData numberCount;
    public Text counterText;

    private void start()
    {
        numberCount.value = 0;
        //counterText.text = numberCount.value.ToString();
    }

    void OnTriggerEnter2D() // physics based function
    {
        numberCount.value += creditValue;
        counterText.text = numberCount.value.ToString();
        gameObject.SetActive(false); // collects object once
    }
}
