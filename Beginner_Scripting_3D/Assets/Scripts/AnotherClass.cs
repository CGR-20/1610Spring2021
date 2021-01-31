using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass
{
    // these variables are made public, so other scripts outside the class can use it
    public int apples;
    public int bananas;

    // when left as 'int', the default value is private
    private int stapler;
    int sellotape;

    // the class is public, so other classes can see and use it
    public void Fruitmachine(int a, int b)
    {
        // the new int 'answer' can only be accessed by the class it's inside (Fruitmachine)
        // despite the fact that the class is public
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }

    // unless called within its parent class, Officesort can't be used by other scripts
    private void Officesort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}
