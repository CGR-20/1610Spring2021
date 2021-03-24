using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private float leftBound = -15;
    private PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        // move obstacle to the left continuously if player doesn't collide with obstacle
        if (playerControllerScript.gameOver == false)
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        // if the game object is way off to the left, destroy object (doesn't destroy bg because tag)
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
    }
}
