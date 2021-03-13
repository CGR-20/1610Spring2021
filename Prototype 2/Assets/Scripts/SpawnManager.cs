using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // creates array that we can drag prefabs to in the inspector

    void Update()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); // generates random number between 0 and size of array
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), 
                animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
