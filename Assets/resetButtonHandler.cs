using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetButtonHandler : MonoBehaviour
{

    private Vector3 startPos;

    void Start()
    {
        startPos = GameObject.Find("Board").transform.position;
        // startPos = new Vector3(
        //     GameObject.Find("Board").transform.position.x,
        //     GameObject.Find("Board").transform.position.y,
        //     GameObject.Find("Board").transform.position.z
        // );
    }

    public void resetBall()
    {
        GameObject.Find("Ball").transform.position = startPos;
    }
    
}
