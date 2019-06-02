using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButtonHandler : MonoBehaviour
{

    private GameObject ball;

    void Start()
    {
        ball = GameObject.Find("Ball");
    }

     public void startBall()
    {
        ball.GetComponent<Rigidbody>().isKinematic = false;
        ball.GetComponent<Rigidbody>().useGravity = true;
    }
}
