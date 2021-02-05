using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateRotate : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    void Update()
    {
        // same as transform.Translate(new Vector3(0, 0, 1));
        // Allows us to move an object when pressing a button
        // Also, because of moveSpeed and deltaTime, the movement is controlled
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        // rotate works the same way
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime);
    }
}
