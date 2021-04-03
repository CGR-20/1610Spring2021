using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject enemyPrefab;
    private Vector3 enemyPos = new Vector3(25, 0, 0);
    private Vector3 obstaclePos = new Vector3(75, 0, 0);
    private float delayRate = 2;
    private float despawnRange;

    void Start()
    {
        // keep creating obstacles
        InvokeRepeating("SpawnObstacle", delayRate, delayRate);
        despawnRange = 40;
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            StartCoroutine(SpawnEnemy());
    }

    void SpawnObstacle()
    {
        // spawn single obstacle
        Instantiate(obstaclePrefab, obstaclePos, obstaclePrefab.transform.rotation);
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(7);
        Instantiate(obstaclePrefab, enemyPos, enemyPrefab.transform.rotation);
    }
}
