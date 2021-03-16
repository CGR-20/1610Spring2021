using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // creates array that we can drag prefabs to in the inspector
    private float spawnRangeX = 20; // horizontal spawn range
    private float spawnPozZ = 20; // start spawn range
    private float startDelay = 2; // delay when animals spawn at beginning
    private float spawnInterval = 1.5f; // speed when animals spawn

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); // spawns animals
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPozZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length); // generates random number between 0 and size of array
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
