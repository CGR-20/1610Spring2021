using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 currentPos;
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        currentPos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        transform.position= currentPos;
    }
}
