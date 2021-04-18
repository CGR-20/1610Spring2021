using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject enemyPrefab;
    //private Vector3 enemyPos;
    private Vector3 obstaclePos;
    private Vector3 spawnDistance;

    public float obstaclePosX;
    public float spawnDistanceX;
    private float stopPosX;

    void Start()
    {
        stopPosX = obstaclePosX;
        obstaclePosX = -obstaclePosX;

        //enemyPos = new Vector3(25, 1, 0);
        obstaclePos = new Vector3(obstaclePosX, 0, -5); // assigns new location for obstacle to spawn
        spawnDistance = new Vector3(spawnDistanceX, 0, 0); // set distance between obstacles
    }

    void Update()
    {
        SpawnObstacles();
    }

    private void SpawnObstacles()
    {
        while (stopPosX > obstaclePos.x)
        {
            // spawn obstacles in a row
            Instantiate(obstaclePrefab, obstaclePos, obstaclePrefab.transform.rotation);
            obstaclePos += spawnDistance;
        }
    }
}
