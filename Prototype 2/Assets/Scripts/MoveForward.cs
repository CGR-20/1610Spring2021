using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 5.0f; // speed at which the projectile moves

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); // moves projectile
    }
}
