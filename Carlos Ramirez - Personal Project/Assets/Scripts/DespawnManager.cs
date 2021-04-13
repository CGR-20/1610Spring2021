using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnManager : MonoBehaviour
{
    private float despawnRange;
    private GameObject player;
    public float despawnDistance;

    private void Start()
    {
        player = GameObject.Find("Player");
        despawnDistance = 40;
    }

    void Update()
    {
        despawnRange = player.transform.position.x + despawnDistance;

        if (transform.position.x < -despawnRange || transform.position.x > despawnRange
            || transform.position.z < -despawnRange || transform.position.z > despawnRange
            || transform.position.y < -despawnRange || transform.position.y > despawnRange)
            Destroy(gameObject);
    }
}
