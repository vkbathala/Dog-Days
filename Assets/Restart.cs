﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    bool enabled = false;
    // Update is called once per frame
    void Update()
    {
        if (enabled)
        {
            Application.LoadLevel(Application.loadedLevel);
        }   
    }
    
}
