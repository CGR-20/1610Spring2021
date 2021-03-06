﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateKeeprBehavior : MonoBehaviour
{
    public BoolData keyObj;

    private void Start()
    {
        keyObj.value = false;
        gameObject.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        keyObj.value = true;
        gameObject.SetActive(false);
    }
}