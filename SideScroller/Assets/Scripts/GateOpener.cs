using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpener : MonoBehaviour
{
    public BoolData keyObj;

    private void Update()
    {
        if (keyObj.value)
            gameObject.SetActive(false);
    }
}
