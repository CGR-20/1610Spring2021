using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScene : MonoBehaviour
{
    private float hInput;
    public float speed;

    void Update()
    {
        ScrollScene();
    }

    private void ScrollScene()
    {
        // player movement
        hInput = Input.GetAxis("Horizontal"); // gets user input
        // move stuff
        transform.Translate(Vector3.right * -hInput * Time.deltaTime * speed);
    }
}
