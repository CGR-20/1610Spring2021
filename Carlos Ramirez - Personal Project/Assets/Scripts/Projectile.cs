using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed; // speed at which the projectile moves
    private PlayerController playerControllerScript;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (!playerControllerScript.faceLeft)
            transform.Translate(Vector3.right * Time.deltaTime * speed); // moves projectile
        else
            transform.Translate(Vector3.left * Time.deltaTime * speed); // moves projectile
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
