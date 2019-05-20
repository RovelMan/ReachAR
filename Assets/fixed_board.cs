using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixed_board : MonoBehaviour
{
    float lockPos = 0;

    void Update()
    {
        transform.rotation = Quaternion.Euler (lockPos, lockPos, lockPos);
    }
}
