using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int number, total;
    public Weapon[] weapons;

    void Start()
    {
        /*
        for (int i = 0; i < number; i++)
        {
            total = i;
            print(total);
        }
        */

        foreach (var weapon in weapons)
            print(message: "You have my " + weapon.name);
    }
}
