using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed;
    private float maxSpeed;
    private float maxTorque;
    private float xRange;
    private float ySpawnPos;


    void Start()
    {
        minSpeed = 12;
        maxSpeed = 16;
        maxTorque = 10;
        xRange = 4;
        ySpawnPos = 6;

        targetRb = GetComponent<Rigidbody>();
        // throws target upwards
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        // adds torque/spin to target
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        // spawns target at random x location 
        transform.position = RandomSpawnPos();
    }

    void Update()
    {
        
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), -ySpawnPos);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
