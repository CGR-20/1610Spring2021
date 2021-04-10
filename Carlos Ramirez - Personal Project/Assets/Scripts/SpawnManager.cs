using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject enemyPrefab;
    private Vector3 enemyPos = new Vector3(25, 1, 0);
    private Vector3 obstaclePos = new Vector3(0, 3, -2);
    private float delayRate = 2.0f;

    void Start()
    {
        // keep creating obstacles
        //InvokeRepeating("SpawnObstacle", delayRate, delayRate);
    }

    void Update()
    {
        //if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        //StartCoroutine(SpawnEnemy());
        SpawnObstacle();
    }

    void SpawnObstacle()
    {
        // spawn obstacles in a row
        Instantiate(obstaclePrefab, obstaclePos, obstaclePrefab.transform.rotation);
        obstaclePos = obstaclePos + new Vector3(25, 0, 0);

    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(7);
        Instantiate(obstaclePrefab, enemyPos, enemyPrefab.transform.rotation);
    }
}
