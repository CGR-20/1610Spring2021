using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    void Start()
    {
        startPos = transform.position; // the bg's current position is it's start position
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // get accurate half x length of background

        Debug.Log(startPos);
        Debug.Log(repeatWidth);
    }

    void Update()
    {
        // if the new bg position has passed a certain point on the left side, bring the bg back to the start
        if (transform.position.x < startPos.x - repeatWidth)
            transform.position = startPos;
    }
}
