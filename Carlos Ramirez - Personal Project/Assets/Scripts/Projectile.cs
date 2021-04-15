using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 5.0f; // speed at which the projectile moves

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed); // moves projectile
    }

    private void OnCollisionEnter(Collision collision)
    {
        // if the projectile hits something, get rid of both
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
