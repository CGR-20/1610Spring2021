using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeStartUpdate : MonoBehaviour
{
    void Awake()
    {
        // Awake is called even if the script component is disabled
        // it's used for self-initializition (creating references and/or initializing stuff before the game)
        // doesn't work well if you want to use another Awake function's code
        Debug.Log("Awake called.");
    }

    // Start is called before the first frame update and used for initalization
    void Start()
    {
        // after Awake is called, functions in Start can now access stuff without worrying about errors
        Debug.Log("Start called.");
    }

    void FixedUpdate()
    {
        // caled every physics step
        // update times are constant
        // used for adjusting physics (ridgidbody) objects
        Debug.Log("FixedUpdate time: " + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        // in the console menu, it's listed a bunch of times
        // used for:
        // moving non-physics objects
        // simple timers
        // reciving input
        // however, update times vary since frames can be different sizes
        Debug.Log("Update time: " + Time.deltaTime);
    }
}
