using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float hInput; // recieves user input in the horizontal direction
    public float speed; // the speed at which the player moves
    public float xRange; // the horizontal range that the player can move in
    public float jumpForce;
    public float gravityModifier;
    private bool isOnGround; // makes sure player can't jump infinitely
    private Vector3 offset;

    public GameObject projectilePrefab; // projectile prefab
    private Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); // gets rigid body of whatever the script is attached to
        Physics.gravity *= gravityModifier; // changes gravity of game
        isOnGround = true; // the player should start on the ground no matter what
        offset = new Vector3(2, 0, 0); // projectile offset
    }

    void Update()
    {
        PlayerMovement();
        PlayerActions();
        ConstrainPlayerPosition();
    }

    // whenever the player collides with anything, do the following
    private void OnCollisionEnter(Collision collision)
    {
        // when player makes collision (ground), allow to jump again
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

    private void PlayerMovement()
    {
        // player movement
        hInput = Input.GetAxis("Horizontal"); // gets user input
        transform.Translate(Vector3.right * hInput * Time.deltaTime * speed); // moves player on input
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

    private void ConstrainPlayerPosition()
    {
        // keep player in bounds
        if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        //if (transform.position.x > xRange)
            //transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }
}
