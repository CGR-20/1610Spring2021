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
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); // gets rigid body of whatever the script is attached to
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier; // changes gravity of game
        isOnGround = true;
        gameOver = false;
    }

    void Update()
    {
        // when the player presses the space key, and they're both on the ground and there's no game over
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // makes player jump
            isOnGround = false; // stops player from spamming jump
            playerAnim.SetTrigger("Jump_trig"); // play jump animation
            dirtParticle.Stop(); // stop dirt animation when in the air
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // when player makes collision (ground), allow to jump again
        if (collision.gameObject.CompareTag("Ground"))
        { 
            isOnGround = true;
            dirtParticle.Play(); // play dirt animation when running on ground
        }
        // when the player collides with obstacle, end game
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_b", true); // let game know that the player died
            playerAnim.SetInteger("DeathType_int", 1); // play death animation
            explosionParticle.Play(); // play explosion animation
            dirtParticle.Stop(); // stop dirt animation when dead
        }
    }
}
