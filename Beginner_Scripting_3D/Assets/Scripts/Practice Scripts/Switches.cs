using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    void Start()
    {
        string word = "Soda";

        switch(word)
        {
            case "Juice":
                Debug.Log("Your drink is juice");
                break;
            case "Beer":
                Debug.Log("Your drink is for men");
                break;
            case "Soda":
                Debug.Log("Your drink is delicious");
                break;
            default:
                Debug.Log("Your drink is either something else or nonexistent");
                break;
        }
    }
}
