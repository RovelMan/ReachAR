﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixed_wall1 : MonoBehaviour
{
    float lockPos = 0;
    
    void Update()
    {
        transform.rotation = Quaternion.Euler (lockPos, GameObject.Find("Wall1").transform.rotation.eulerAngles.y, lockPos);
    }
}
