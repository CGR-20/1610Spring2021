using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject enemyPrefab;
    private Vector3 enemyPos;
    private Vector3 obstaclePos;
    private Vector3 mirrorPos;
    private Vector3 spawnDistance;

    public float obstaclePosX;
    public float spawnDistanceX;
    private float stopPosX;

    void Start()
    {
        stopPosX = obstaclePosX;
        obstaclePosX = -obstaclePosX;

        //enemyPos = new Vector3(25, 1, 0);
        obstaclePos = new Vector3(obstaclePosX, 2, -5);
        spawnDistance = new Vector3(spawnDistanceX, 0, 0);
        SpawnObstacle();

        Debug.Log(obstaclePosX);
        Debug.Log(spawnDistanceX);
        Debug.Log(stopPosX);
        Debug.Log(obstaclePos);
        Debug.Log(spawnDistance);
    }

    void Update()
    {
        //mirrorPos = new Vector3(-obstaclePos.x, obstaclePos.y, obstaclePos.z);
        //SpawnObstacle();
    }

    void SpawnObstacle()
    {
        while (stopPosX > obstaclePosX)
        {
            // spawn obstacles in a row
            Instantiate(obstaclePrefab, obstaclePos, obstaclePrefab.transform.rotation);
            //Instantiate(obstaclePrefab, mirrorPos, obstaclePrefab.transform.rotation);
            obstaclePos += spawnDistance;
        }
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(7);
        Instantiate(obstaclePrefab, enemyPos, enemyPrefab.transform.rotation);
    }
}
