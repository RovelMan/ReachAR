using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixed_wall3 : MonoBehaviour
{
    float lockPos = 0;
    
    void Update()
    {
        transform.rotation = Quaternion.Euler (lockPos, GameObject.Find("Wall3").transform.rotation.eulerAngles.y, lockPos);
    }
}
