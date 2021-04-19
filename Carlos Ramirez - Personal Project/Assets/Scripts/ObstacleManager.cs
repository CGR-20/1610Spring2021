using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstacle;
    private Obstacle obstacleScript; 
    private float resetPosX;

    private void Update()
    {
        obstacleScript = obstacle.GetComponent<Obstacle>();
        resetPosX = obstacleScript.resetPosX;
        StartCoroutine(ResetObstacles());
    }

    IEnumerator ResetObstacles()
    {
        foreach (Transform child in this.transform)
        {
            yield return new WaitForSeconds(3);
            if (!child.gameObject.activeSelf)
            {
                child.gameObject.SetActive(true);
                child.transform.position = new Vector3(Random.Range(-resetPosX, resetPosX), 
                    Random.Range(0, 8), -5); ;
            }
        }     
    }
}
