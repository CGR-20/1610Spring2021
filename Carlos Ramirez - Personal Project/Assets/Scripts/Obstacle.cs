using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float resetPosX;
    private GameObject obstacleManager;

    public AudioClip explosionSound;
    private AudioSource projectileAudio;
    public ParticleSystem explosionParticle;

    void Start()
    {
        obstacleManager = GameObject.Find("ObstacleManager");
        gameObject.transform.SetParent(obstacleManager.transform, true);
    }

    void Update()
    {
        ResetObstacle();
    }

    public void ResetObstacle()
    {
        // if the obstacle's position is too far to the left, reset it's position to the far right
            if (transform.position.x < -resetPosX)
            transform.position = new Vector3(resetPosX, transform.position.y, transform.position.z);

        // else if do the opposite, but move the obstacle to the far left
        else if (transform.position.x > resetPosX)
            transform.position = new Vector3(-resetPosX, transform.position.y, transform.position.z);
    }

    public void OnCollisionEnter(Collision collision)
    {
        //transform.parent.GetComponent<ObstacleManager>().CollisionDetected(this);

        if (collision.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("Child collided with player");
            projectileAudio.PlayOneShot(explosionSound, 1.0f);
            explosionParticle.Play();
        }
    }
}
