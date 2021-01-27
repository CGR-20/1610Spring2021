using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballGenerator : MonoBehaviour
{
    public GameObject Ball;
    int counter = 0;

    IEnumerator Start()
    {
        while (counter < 25)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(Ball);
            counter++;
        }
    }
}
