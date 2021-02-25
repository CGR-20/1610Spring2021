using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownBehavior : MonoBehaviour
{
    public int maxNumber = 4;
    public float holdTime = 1f;
    public Text countDownText;

    private WaitForSeconds wfsObj;
    public int number = 3;

    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(holdTime);

        while (number > 0)
        {
            countDownText.text = number.ToString();
            number--;
            yield return wfsObj;
        }
        countDownText.text = "GO!";
        yield return wfsObj;
        countDownText.text = null;
    }
}
