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
        ResetObstacle(resetPosX);
    }

    public void ResetObstacle(float resetPosX)
    {
        foreach (Transform child in obstacleManager.transform)
        {
            if (child.transform.position.x < -resetPosX || child.transform.position.x > resetPosX)
                child.gameObject.SetActive(true);

            // if the obstacle's position is too far to the left, reset it's position to the far right
            if (child.transform.position.x < -resetPosX)
                child.transform.position = new Vector3(resetPosX, child.transform.position.y, child.transform.position.z);

            // else if do the opposite, but move the obstacle to the far left
            else if (child.transform.position.x > resetPosX)
                child.transform.position = new Vector3(-resetPosX, child.transform.position.y, child.transform.position.z);
        } 
    }
}
