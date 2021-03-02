using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    void Start()
    {
        
    }
    void Update()
    {
        // Move the vehicle forward
        //transform.Translate(0, 0, 1); // moves in the z axis by 1 each frame
        transform.Translate(Vector3.forward * Time.deltaTime * speed); // easier since Vector3 is the 3D object
        // Vector3.forward equals 0,0,1
        // Time.deltaTime is equal to 1 m/s
    }
}
