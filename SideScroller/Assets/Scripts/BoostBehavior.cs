using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostBehavior : MonoBehaviour
{ 
    public bool haveKey;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (haveKey)
            print(message: true);
    }
}
