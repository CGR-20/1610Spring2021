using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    private float spawnRange; // controls area where enemy spawns at
    private int enemyCount;
    private int waveNumber;

    void Start()
    {
        spawnRange = 9;
        waveNumber = 1;
    }

    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length; // keeps track of number of enemies
        // resets entire playing field after each enemy wave
        if (enemyCount == 0)
        {
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
            SpawnEnemyWave(waveNumber);
            waveNumber++;
        }  
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
