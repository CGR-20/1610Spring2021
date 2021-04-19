using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horsePower; // vehicle forward/backward speed
    [SerializeField] float turnSpeed; // vehicle turn speed
    private float hInput; // horizontal input
    private float fInput; // forward input
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] float speed;
    [SerializeField] float rpm;
    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    void FixedUpdate()
    {
        hInput = Input.GetAxis("Horizontal"); // these get player inputs via arrow keys
        fInput = Input.GetAxis("Vertical"); // allows us to control the vehicle

        if (IsOnGround())
        {
            // Move the vehicle forward
            playerRb.AddRelativeForce(Vector3.forward * horsePower * fInput);

            transform.Rotate(Vector3.up * turnSpeed * hInput * Time.deltaTime); // rotates instead of slides

            speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f);
            speedometerText.SetText("Speed: " + speed + "mph");

            rpm = Mathf.Round((speed % 30) * 40);
            rpmText.SetText("RPM: " + rpm);
        }
        
    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
                wheelsOnGround++;
        }

        if (wheelsOnGround == 4)
            return true;
        else
            return false;
    }
}
