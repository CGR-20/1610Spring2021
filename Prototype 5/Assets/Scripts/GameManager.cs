using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private float spawnRate;
    private int score;
    public bool isGameActive;

    void Start()
    {
        isGameActive = true;
        spawnRate = 2.0f;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(score);
    }

    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            // wait a bit
            yield return new WaitForSeconds(spawnRate);
            // get new index number from array list
            int index = Random.Range(0, targets.Count);
            // spawn target from array
            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }
}
