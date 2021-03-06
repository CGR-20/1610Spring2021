using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public GameObject propeller;
    public float rotationSpeed = 200.0f;
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed); // rotate around z axis
    }
}
