using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject enemyPrefab;
    private GameObject player;
    private Vector3 enemyPos = new Vector3(25, 1, 0);
    private Vector3 obstaclePos = new Vector3(0, 3, -2);
    private Vector3 playerPos;
    private Vector3 spacePos;

    void Start()
    {
        // keep creating obstacles
        //InvokeRepeating("SpawnObstacle", delayRate, delayRate);
        player = GameObject.Find("Player");
        spacePos = new Vector3(25, 0, 0);
    }

    void Update()
    {
        playerPos = player.transform.position;
        SpawnObstacle();
    }

    void SpawnObstacle()
    {
        // spawn obstacles in a row
        Instantiate(obstaclePrefab, obstaclePos, obstaclePrefab.transform.rotation);
        obstaclePos += new Vector3(25, 0, 0);

    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(7);
        Instantiate(obstaclePrefab, enemyPos, enemyPrefab.transform.rotation);
    }
}
