using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButtonHandler : MonoBehaviour
{

    private GameObject ball;
    private GameObject ControlCanvas;

    private ball_physics script;

    // private GameObject ARCamera;
    void Start()
    {
        ball = GameObject.Find("Ball");
        ControlCanvas = GameObject.Find("ControlCanvas");
        // ARCamera = GameObject.Find("ARCamera");
        // ARCamera.transform.position = new Vector3(0f, 0.79f, 0f);
        // ARCamera.transform.rotation = Quaternion.Euler(90f, -180f, 0f);
        script = (ball_physics) ball.GetComponent(typeof(ball_physics));
    }

     public void startBall()
    {  
        ControlCanvas.SetActive(false);
        script.StartRolling();
    }
}
