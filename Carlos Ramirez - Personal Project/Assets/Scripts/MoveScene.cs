﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScene : MonoBehaviour
{
    private float hInput;
    public float speed;

    private PlayerController playerControllerScript;
    private bool gameOver;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        gameOver = playerControllerScript.gameOver;

        if (!gameOver)
            ScrollScene();
    }

    public void ScrollScene()
    {
        // player movement
        hInput = Input.GetAxis("Horizontal");

        // move stuff
        transform.Translate(Vector3.right * -hInput * Time.deltaTime * speed);
    }
}
