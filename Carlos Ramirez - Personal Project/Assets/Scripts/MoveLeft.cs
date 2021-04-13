using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private GameObject player;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        // move in relation to player
        transform.position = new Vector3(-player.transform.position.x, 
            transform.position.y, transform.position.z);
    }
}
