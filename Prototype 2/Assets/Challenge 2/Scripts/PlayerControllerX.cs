using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float time = 1.0f; // starts off counter at 1 second

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime + time; // increases time linearly
        // On spacebar press, send dog whenever one second have passed
        if (Input.GetKeyDown(KeyCode.Space) && time > 1)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            time = 0;
        }
    }
}
