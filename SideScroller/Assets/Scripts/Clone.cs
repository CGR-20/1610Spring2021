using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    public GameObject Ball;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(Ball);
        gameObject.SetActive(false);
    }
}