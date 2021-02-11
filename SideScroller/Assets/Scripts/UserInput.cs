using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Rigidbody2D rigidbodyObj; // refers to object
    public Vector2 direction; // both vectors refer to x and y direction of selected object
    public Vector2 yDir;
    public float speed = 15f;
    public float jumpForce = 8f;
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * speed; // gets user input 
        rigidbodyObj.AddForce(direction, ForceMode2D.Force); // does user input

        if (Input.GetButtonDown("Jump"))
        {
            yDir.y = jumpForce;
            rigidbodyObj.AddForce(yDir, ForceMode2D.Impulse); // gives force to object to make it jump
        }
    }
}