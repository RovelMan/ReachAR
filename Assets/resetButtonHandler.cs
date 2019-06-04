using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetButtonHandler : MonoBehaviour
{

    private Vector3 startPos;
    private GameObject ball;
    private GameObject board;

    void Start()
    {
        ball = GameObject.Find("Ball");
        board = GameObject.Find("Board");
    }

    public void resetBall()
    {
        ball.GetComponent<Rigidbody>().isKinematic = true;
        ball.GetComponent<Rigidbody>().useGravity = false;
        startPos = new Vector3(
            board.transform.position.x,
            board.transform.position.y+0.1f,
            board.transform.position.z
        );
        ball.transform.position = startPos;
        ball.transform.rotation = Quaternion.Euler(0, 0, 0);
        Debug.Log("reset");
    }
    
}
