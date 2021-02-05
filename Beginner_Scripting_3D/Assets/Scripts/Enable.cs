using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable : MonoBehaviour
{
    private Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        // sets up light as component
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        // the space bar is the toggle
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // this basically allows the user to switch the lighting
            myLight.enabled = !myLight.enabled;
        }
    }
}
