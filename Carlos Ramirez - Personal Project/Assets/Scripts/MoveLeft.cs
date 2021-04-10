using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public GameObject player;
    private Vector3 playerXPos;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        // move in relation to player
        transform.position = new Vector3(-player.transform.position.x, 
            transform.position.y, transform.position.z);
    }
}
