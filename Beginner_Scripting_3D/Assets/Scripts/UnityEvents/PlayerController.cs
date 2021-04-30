using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float vInput;
    private float hInput;
    public float speed;

    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * hInput * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime);
    }
}
