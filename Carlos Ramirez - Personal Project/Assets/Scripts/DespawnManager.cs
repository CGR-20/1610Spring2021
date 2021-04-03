using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnManager : MonoBehaviour
{
    private float despawnRange;

    void Start()
    {
        despawnRange = 40;
    }

    void Update()
    {
        if (transform.position.x < -despawnRange || transform.position.x > despawnRange)
            Destroy(gameObject);
    }
}
