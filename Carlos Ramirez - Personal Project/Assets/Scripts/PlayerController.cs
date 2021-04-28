using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float gravityModifier;
    private bool isOnGround; // makes sure player can't jump infinitely
    private Vector3 offsetRight;
    private Vector3 offsetLeft;
    private float offsetX;
    private float offsetY;

    public GameObject projectilePrefab; // projectile prefab
    private Rigidbody playerRb;

    private Vector3 rotation;
    private Quaternion startRotation;

    public bool faceLeft;
    public bool gameOver;

    private AudioSource cameraAudio;
    private AudioSource playerAudio;
    public Animator playerAnim;
    public AudioClip crashSound;
    public AudioClip jumpSound;
    public AudioClip projectileSound;
    public ParticleSystem dirtParticle;

    void Start()
    {
        offsetX = GetComponent<BoxCollider>().size.x;
        offsetY = GetComponent<BoxCollider>().size.y / 2;

        playerRb = GetComponent<Rigidbody>(); // gets rigid body of whatever the script is attached to
        Physics.gravity = new Vector3(0, gravityModifier, 0);
        offsetRight = new Vector3(offsetX, offsetY, 0); // projectile offset
        offsetLeft = new Vector3(-offsetX, offsetY, 0);

        startRotation = transform.rotation; // keep track of original direction
        rotation = new Vector3(0, 180, 0); // amount of rotation the player makes
        isOnGround = false;

        gameOver = false;
        cameraAudio = Camera.main.GetComponent<AudioSource>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!gameOver)
        {
            PlayerActions();
            PlayerDirection();
        }
    }

    // actions that the player is able to perform
    private void PlayerActions()
    {
        // when the player presses the space key, and they're on the ground, jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // makes player jump
            isOnGround = false; // stops player from spamming jump
            playerAudio.PlayOneShot(jumpSound, 1.0f);
            dirtParticle.Stop();
            playerAnim.SetBool("Jump_b", true);
        }

        // launch projectile from player as long as there isn't another on screen
        if (Input.GetKeyDown(KeyCode.Space) && GameObject.FindGameObjectsWithTag("Projectile").Length == 0)
        {
            playerAudio.PlayOneShot(projectileSound, 1.0f);
            playerAnim.SetBool("Shoot_b", true);

            if (faceLeft)
                Instantiate(projectilePrefab, transform.position + offsetLeft,
                    projectilePrefab.transform.rotation);
            else
                Instantiate(projectilePrefab, transform.position + offsetRight,
                    projectilePrefab.transform.rotation);
        }
    }

    // make player face the correct way
    private void PlayerDirection()
    {
        // if the player holds down the left key, and the player's current rotated position is the starting
        // position (facing right), look left
        if (Input.GetKey(KeyCode.LeftArrow) && transform.rotation == startRotation)
        {
            transform.Rotate(rotation); // rotates player
            faceLeft = true;
            
        }

        // else if, do the opposite from the action above and look right
        else if (Input.GetKey(KeyCode.RightArrow) && transform.rotation != startRotation)
        {
            transform.Rotate(rotation); // rotates player
            faceLeft = false;
        }
    }

    // whenever the player collides with anything, do the following
    private void OnCollisionEnter(Collision collision)
    {
        // when player makes collision (ground), allow to jump again
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            playerAnim.SetBool("Jump_b", false); // player is no longer jumping
            dirtParticle.Play();
        }

        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            cameraAudio.Stop();
            playerAnim.SetBool("Death_b", true);
            playerAudio.PlayOneShot(crashSound, 1.0f);
            dirtParticle.Stop();
        }
    }
}
