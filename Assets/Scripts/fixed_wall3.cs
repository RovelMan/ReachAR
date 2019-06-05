using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class fixed_wall3 : MonoBehaviour
{
    float lockPos = 0;
    
    void Update()
    {
        transform.rotation = Quaternion.Euler(lockPos, GameObject.Find("Wall3").transform.rotation.eulerAngles.y, lockPos);
        try {
            GameObject.Find("Wall3").transform.position = new Vector3(
                GameObject.Find("Wall3").transform.position.x,
                GameObject.Find("Board").transform.position.y,
                GameObject.Find("Wall3").transform.position.z
            );
        }
        catch (Exception e) {
            print("Error");
        }
    }
}
