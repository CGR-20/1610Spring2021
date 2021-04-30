using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCube : MonoBehaviour
{
    // this script is attached to a game/object manager
    // it also holds the game object to manipulate
    // as well as additional scripts that can affect the object

    [SerializeField] private GameObject myCube;
    public void SetCubeTrue()
    {
        myCube.SetActive(true);
    }

    public void Message()
    {
        Debug.Log("This is an example of UnityEvents");
    }

    public void SetCubeFalse()
    {
        myCube.SetActive(false);
    }

}
