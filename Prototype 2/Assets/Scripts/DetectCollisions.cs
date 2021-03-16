using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // this script is applied to the animals, so it deletes them
        Destroy(other.gameObject); // the projectile is erased as well
    }
}
