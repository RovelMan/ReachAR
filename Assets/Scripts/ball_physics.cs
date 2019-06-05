using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_physics : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector3 _velocity;
    private LineRenderer arrow;

    private Vector3 initialPos;
    private GameObject ball;
    private GameObject board;

    // private GameObject ARCamera;
    // Use this for initialization
    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
        ball = GameObject.Find("Ball");
        initialPos = ball.transform.position;
        board = GameObject.Find("Board");
        // ARCamera = GameObject.Find("ARCamera");
        // ARCamera.transform.position = board.transform.position + new Vector3(0f, 1f, 0f);
        // ARCamera.transform.rotation = Quaternion.Euler(180f, -180f, 0);
        arrow = ball.GetComponent(typeof(LineRenderer)) as LineRenderer;
        _velocity = new Vector3(0f, 0f, .5f);

        _rb.AddForce(_velocity, ForceMode.VelocityChange);

        arrow.SetPosition(0, ball.transform.position);
        arrow.SetPosition(1, ball.transform.position + Vector3.Scale(_velocity, new Vector3(0.1f, 0.1f, 0.1f)));
    }

    void OnCollisionEnter(Collision collision){
        ReflectProjectile(_rb, collision.contacts[0].normal);
    }

    public void DisableArrow()
    {
        arrow.enabled = false;
    }
    private void ReflectProjectile(Rigidbody rb, Vector3 reflectVector)
    {    
        _rb.velocity = Vector3.Reflect(_velocity, reflectVector);
    }

    public void ResetBall() 
    {   
        _rb.isKinematic = true;
        _rb.useGravity = false;
        // Vector3 startPos = new Vector3(
        //     board.transform.position.x,
        //     board.transform.position.y+initialPos.y,
        //     board.transform.position.z
        // );
        ball.transform.position = initialPos;
        _rb.velocity = Vector3.zero;
        _rb.angularVelocity = Vector3.zero;
        _rb.AddForce(_velocity, ForceMode.VelocityChange);

        arrow.SetPosition(0, ball.transform.position);
        arrow.SetPosition(1, ball.transform.position + Vector3.Scale(_velocity, new Vector3(0.1f, 0.1f, 0.1f)));
        arrow.enabled = true;
    }
    void Update()
    {
    }
}
