using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    private float spawnRate;
    private int score;

    void Start()
    {
        spawnRate = 2.0f;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
    }

    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            // wait a bit
            yield return new WaitForSeconds(spawnRate);
            // get new index number from array list
            int index = Random.Range(0, targets.Count);
            // spawn target from array
            Instantiate(targets[index]);
            UpdateScore(5);
        }
    }

    private void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
