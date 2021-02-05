using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    // look at public objects that move
    public Transform target;
    void Update()
    {
        // lookAt makes the selected object the center of attention
        transform.LookAt(target);
    }
}
