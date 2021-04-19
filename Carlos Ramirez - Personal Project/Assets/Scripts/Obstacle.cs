using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float resetPosX;
    private GameObject obstacleManager;

    void Start()
    {
        obstacleManager = GameObject.Find("ObstacleManager");
        gameObject.transform.SetParent(obstacleManager.transform, true);
    }

    void Update()
    {
        ResetObstacle();
    }

    public void ResetObstacle()
    {
        // if the obstacle's position is too far to the left, reset it's position to the far right
            if (transform.position.x < -resetPosX)
            transform.position = new Vector3(resetPosX, transform.position.y, transform.position.z);

        // else if do the opposite, but move the obstacle to the far left
        else if (transform.position.x > resetPosX)
            transform.position = new Vector3(-resetPosX, transform.position.y, transform.position.z);
    }
}
