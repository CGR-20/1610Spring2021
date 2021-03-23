using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround;
    public bool gameOver;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); // gets rigid body of whatever the script is attached to
        Physics.gravity *= gravityModifier; // changes gravity of game
        isOnGround = true;
        gameOver = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // makes player jump
            isOnGround = false; // stops player from spamming jump
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // when player makes collision (ground), allow to jump again
        if (collision.gameObject.CompareTag("Ground"))
            isOnGround = true;
        // when the player collides with obstacle, end game
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
        }
    }
}
