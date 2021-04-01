using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9; // controls area where enemy spawns at
    public int enemiesToSpawn;
    public int enemyCount;

    void Start()
    {
        
    }

    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length; // keeps track of number of enemies
        if (enemyCount == 0)
            SpawnEnemyWave(1);
    }

    private void SpawnEnemyWave(int enemies)
    {
        for (int i = 0; i < enemies; i++)
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ); // spawns on top of arena
        return randomPos;
    }
}
