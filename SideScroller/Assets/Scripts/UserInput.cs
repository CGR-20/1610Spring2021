using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Rigidbody2D ball;
    public Vector2 direction;
    public Vector2 yDir;
    public float speed = 3f;
    public float jumpForce = 300f;
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * speed;
        ball.AddForce(direction, ForceMode2D.Force);

        if (Input.GetButtonDown("Jump"))
        {
            yDir.y = jumpForce;
            ball.AddForce(yDir, ForceMode2D.Force);
        }
    }
}
