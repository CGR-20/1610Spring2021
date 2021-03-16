using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput; // recieves user input in the horizontal direction
    public float speed = 10.0f; // the speed at which the player moves
    public float xRange = 10; // the horizontal range that the player can move in

    public GameObject projectilePrefab; // refers to existing item with specific attributes (prefab)

    void Update()
    {
        hInput = Input.GetAxis("Horizontal"); // gets user input
        transform.Translate(Vector3.right * hInput * Time.deltaTime * speed); // moves player on input

        // keep player in bounds
        if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        // launch food from player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
