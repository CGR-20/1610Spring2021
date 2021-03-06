﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // allows us to tell the script to focus on the vehicle
    [SerializeField] Vector3 offset = new Vector3(0, 2, 4); // offsets camera so it's not inside the vehicle
    // 0, 10, -12
    void LateUpdate()
    {
        transform.position = player.transform.position + offset; // updates the camera
        // position to follow the player, while also offseting the camera to be above and behind the player
    }
}
