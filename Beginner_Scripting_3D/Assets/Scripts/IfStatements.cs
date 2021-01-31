using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    // float is like int, except that it takes in decimals
    // not sure about the f part though, but I'll learn soon enough

    // coffeeTemp is the starting temperature
    // hotLimit is the hightest temperature that the coffee is too hot to drink
    // same with coldLimit
    float coffeeTemp = 85.0f;
    float hotLimit = 70.0f;
    float coldLimit = 40.0f;

    // Update is called once per frame
    void Update()
    {
        // if the button pushed is space, do temperature test
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        // coffee's temperature shrinks over time
        coffeeTemp -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // if the coffee is too hot (over the hotest temperature)
        if (coffeeTemp > hotLimit)
        {
            // tell the user that it's too hot
            print("Coffee is too hot.");
        }
        // if it's below the comfortable temperature, it's too cold
        else if (coffeeTemp < coldLimit)
        {
            print("Coffee is too cold.");
        }
        // if it's not hot or cold, it means that it's in the correct range
        else
        {
            print("Coffee is just right.");
        }
    }
}
