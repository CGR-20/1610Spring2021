using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed; // speed at which the projectile moves
    private PlayerController playerControllerScript;

    private Rigidbody projectileRb;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        projectileRb = GetComponent<Rigidbody>();

        Destroy(gameObject, 3f); // safety precaution so that projectile is destroyed in three seconds
    }

    void Update()
    {
        // if the player is not facing left, shoot to the right
        if (!playerControllerScript.faceLeft)
            projectileRb.AddForce(projectileRb.transform.right * speed);
        else
            projectileRb.AddForce(-projectileRb.transform.right * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // if the projectile hits something, get rid of both
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            collision.gameObject.SetActive(false);
        }
    }
}
