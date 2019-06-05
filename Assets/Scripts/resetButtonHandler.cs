using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetButtonHandler : MonoBehaviour
{

    // private Vector3 startPos;
    private GameObject ball;
    // private GameObject board;

    private ball_physics script;
    private GameObject ControlCanvas;

    void Start()
    {
        ball = GameObject.Find("Ball");
        script = (ball_physics) ball.GetComponent(typeof(ball_physics));
        // board = GameObject.Find("Board");
        ControlCanvas = GameObject.Find("ControlCanvas");
    }

    public void resetBall()
    {
        // ball.GetComponent<Rigidbody>().isKinematic = true;
        // ball.GetComponent<Rigidbody>().useGravity = false;
        // startPos = new Vector3(
        //     board.transform.position.x,
        //     board.transform.position.y+0.1f,
        //     board.transform.position.z
        // );
        // ball.transform.position = startPos;
        // ball.transform.rotation = Quaternion.Euler(0, 0, 0);
        script.ResetBall();
        ControlCanvas.SetActive(true);
        Debug.Log("reset");
    }
    
}
