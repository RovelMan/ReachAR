using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButtonHandler : MonoBehaviour
{

    private GameObject ball;
    private GameObject ControlCanvas;

    void Start()
    {
        ball = GameObject.Find("Ball");
        ControlCanvas = GameObject.Find("ControlCanvas");
    }

     public void startBall()
    {  
        ControlCanvas.SetActive(false); 
        ball.GetComponent<Rigidbody>().isKinematic = false;
        ball.GetComponent<Rigidbody>().useGravity = true;
    }
}
