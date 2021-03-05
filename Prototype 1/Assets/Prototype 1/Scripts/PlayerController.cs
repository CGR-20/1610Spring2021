using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f; // vehicle forward/backward speed
    private float turnSpeed = 50.0f; // vehicle turn speed
    private float hInput; // horizontal input
    private float fInput; // forward input

    void Update()
    {
        hInput = Input.GetAxis("Horizontal"); // these get player inputs via arrow keys
        fInput = Input.GetAxis("Vertical"); // allows us to control the vehicle
        // Move the vehicle forward
        //transform.Translate(0, 0, 1); // moves in the z axis by 1 each frame
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput); // easier since Vector3 is the 
        // 3D object
        // Vector3.forward equals 0,0,1
        // Time.deltaTime is equal to 1 m/s
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * hInput); // rotates instead of slides
    }
}
