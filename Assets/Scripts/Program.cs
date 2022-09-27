using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Program : MonoBehaviour
{

    [SerializeField] SearchPath SP;

    bool isWatch = false;

    private void Update()
    {
        if(!isWatch)
        {
            Debug.Log(SP.elapsedMs);
           isWatch = true;
        }
    }

}