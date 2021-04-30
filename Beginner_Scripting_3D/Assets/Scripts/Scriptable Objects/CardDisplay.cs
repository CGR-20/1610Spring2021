using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    void Start()
    {
        card.PrintInformation();
    }
}
