using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScene : MonoBehaviour
{
    private float hInput;
    public float speed;
    public GameObject player;
    private PlayerController playerControllerScript;

    void Start()
    {

    }

    void Update()
    {
        ScrollScene();
    }

    private void ScrollScene()
    {
        // player movement
        hInput = Input.GetAxis("Horizontal");

        // rotate player to face correct direction

        // make player face the right way
        if (hInput < 0)
            player.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
        else if (hInput > 0)
            player.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);

        // move stuff
        transform.Translate(Vector3.right * -hInput * Time.deltaTime * speed);
    }
}
