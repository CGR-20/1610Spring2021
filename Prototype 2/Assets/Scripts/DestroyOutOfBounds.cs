using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 20; // this is meant for the player projectile
    private float lowerBound = -10; // this is for the animals
    void Update()
    {
        if (transform.position.z > topBound) // stops projectile from continuing forever
            Destroy(gameObject);
        else if (transform.position.z < lowerBound) // if any animals make it past, they're erased
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }  
    }
}
