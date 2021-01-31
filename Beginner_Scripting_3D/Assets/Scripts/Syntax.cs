using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log and transform.position.x refer to things within things
        // for example, we're using the transform's position function in conjuntion with the x value
        // aka we're looking at the object's x position
        Debug.Log(transform.position.x);

        // also, indents are used to make things easier to read
        if (transform.position.y <= 5f)
            // for example, the line below is indented once, meaning the line before it is the condition 
            // statement
            Debug.Log("Ground impact imminient");
    }
}
// also, comments like these exist to make development of code easier
