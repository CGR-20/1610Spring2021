using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballGenerator : MonoBehaviour
{
    public GameObject Ball;
    int counter = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        IEnumerator Start()
        {
            while (counter < 3)
            {
                yield return new WaitForSeconds(0.5f);
                Instantiate(Ball);
                counter++;
            }
            gameObject.SetActive(false);
        }
    }
}
