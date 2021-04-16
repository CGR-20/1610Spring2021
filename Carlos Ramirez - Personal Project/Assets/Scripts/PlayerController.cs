using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float gravityModifier;
    private bool isOnGround; // makes sure player can't jump infinitely
    private Vector3 offset;
    private float offsetX;
    private float offsetY;

    public GameObject projectilePrefab; // projectile prefab
    private Rigidbody playerRb;

    void Start()
    {
        offsetX = GetComponent<BoxCollider>().size.x;
        offsetY = GetComponent<BoxCollider>().size.y / 2;

        playerRb = GetComponent<Rigidbody>(); // gets rigid body of whatever the script is attached to
        Physics.gravity = new Vector3(0, gravityModifier, 0);
        offset = new Vector3(offsetX, offsetY, 0); // projectile offset
    }

    void Update()
    {
        PlayerActions();
    }

    private void PlayerActions()
    {
        // when the player presses the space key, and they're on the ground, jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // makes player jump
            isOnGround = false; // stops player from spamming jump
        }

        // launch projectile from player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position + offset, projectilePrefab.transform.rotation);
        }
    }

    // whenever the player collides with anything, do the following
    private void OnCollisionEnter(Collision collision)
    {
        // when player makes collision (ground), allow to jump again
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
