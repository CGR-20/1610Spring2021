using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject player; // allows us to tell the script to focus on the player
    private Vector3 offset = new Vector3(0, 6, -20); // offsets camera so it's not inside the player

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        transform.position = player.transform.position + offset; // updates the camera
        // position to follow the player, while also offseting the camera to see the main screen
    }
}
