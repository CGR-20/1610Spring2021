using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnManager : MonoBehaviour
{
    public float despawnRange;

    void Update()
    {
        if (transform.position.x < -despawnRange || transform.position.x > despawnRange)
            Destroy(gameObject);
    }
}
