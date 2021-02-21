using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int creditValue = 3;
    public IntData numberCount;
    public Text counterText;

    private void Start()
    {
        numberCount.value = 0;
    }

    void OnTriggerEnter2D() // physics based function
    {
        numberCount.value += creditValue;
        counterText.text = numberCount.value.ToString();
        gameObject.SetActive(false); // collects object once
    }
}
