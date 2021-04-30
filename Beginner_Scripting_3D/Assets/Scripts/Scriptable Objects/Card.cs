using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")] // tells unity to allow us to create game object
// with this template
// also changes menu names to make things easier to navigate

public class Card : ScriptableObject // since this won't attach to an object, we don't use Monospace
{
    // below are all the attributes the card template/object will contain
    public new string name;
    public string description;
    public Sprite artwork;
    public int manaCost;
    public int attack;
    public int health;

    public void PrintInformation() // when called, prints card's information
    {
        Debug.Log(name);
        Debug.Log(description);
        //Debug.Log(card.name);
        Debug.Log(manaCost);
        Debug.Log(attack);
        Debug.Log(health);
    }
}
