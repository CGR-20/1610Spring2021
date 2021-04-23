using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstacle;
    private Obstacle obstacleScript; 
    private float resetPosX;

    public AudioClip explosionSound;
    private AudioSource projectileAudio;
    //public ParticleSystem explosionParticle;

    private void Start()
    {
        projectileAudio = GetComponent<AudioSource>();
    }

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
            if (!child.gameObject.activeSelf)
            {
                projectileAudio.PlayOneShot(explosionSound, 1.0f);
                //explosionParticle.Play();
            }
 
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
