using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private GameManager gameManager;
    private float minSpeed;
    private float maxSpeed;
    private float maxTorque;
    private float xRange;
    private float ySpawnPos;
    public int pointValue;
    public ParticleSystem explosionParticle;

    void Start()
    {
        minSpeed = 14;
        maxSpeed = 18;
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

        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
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
        if (gameManager.isGameActive)
        {
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            gameManager.UpdateScore(pointValue);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
            gameManager.GameOver();
    }
}
