using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ball_physics : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector3 _velocity;
    private LineRenderer arrow;

    private Vector3 initialBallPos;

    private GameObject ball;

    private bool isOriginal;
    private GameObject ballClone;
    private GameObject board;

    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
        ball = gameObject;

        if (ball.name.Contains("Clone")) {
            isOriginal = false;
        } else {
            isOriginal = true;
        }

        string SceneName = SceneManager.GetActiveScene().name;
        switch(SceneName)
        {
            case "Level1":
                _velocity = new Vector3(0f, 0f, 10f);
                break;
            case "Level2":
                _velocity = new Vector3(0f, 0f, 10f);
                break;
            case "Level3":
                _velocity = new Vector3(0f, 0f, 10f);
                break;
            case "Level4":
                _velocity = new Vector3(0f, 0f, -10f);
                break;
            default:
                _velocity = new Vector3(0f, 0f, 10f);
                break;
        }
        

        _rb.AddForce(_velocity, ForceMode.VelocityChange);
        // _rb.AddForce(_velocity, ForceMode.ConstantForce);
        if (isOriginal) {
            initialBallPos = ball.transform.position;

            board = GameObject.Find("Board");
            arrow = ball.GetComponent(typeof(LineRenderer)) as LineRenderer;


            arrow.SetPosition(0, ball.transform.position);
            arrow.SetPosition(1, ball.transform.position + Vector3.Scale(_velocity, new Vector3(0.1f, 0.1f, 0.1f)));
        }

    }

    void OnCollisionEnter(Collision collision){
        ContactPoint cp = collision.contacts[0];
         // calculate with addition of normal vector
         // myRigidbody.velocity = oldVel + cp.normal*2.0f*oldVel.magnitude;
         
         // calculate with Vector3.Reflect
        _rb.velocity = Vector3.Reflect(_rb.velocity,cp.normal);
         
         // bumper effect to speed up ball
        // myRigidbody.velocity += cp.normal*2.0f;
        // for (int i = 0; i < collision.contacts.Length; i++)
        // {
        //     ReflectProjectile(_rb, collision.contacts[i].normal);
        // }
    }

    public void StartRolling()
    {

        if (isOriginal && ballClone == null) {
            arrow.enabled = false;
            ball.SetActive(false);
            ballClone = Instantiate(ball, board.transform);
            ballClone.SetActive(true);
            ballClone.GetComponent<Rigidbody>().isKinematic = false;
            ballClone.GetComponent<Rigidbody>().useGravity = true;
        }
    }
    private void ReflectProjectile(Rigidbody rb, Vector3 reflectVector)
    {    reflectVector.y = 0f;
        _rb.velocity = Vector3.Reflect(_velocity, reflectVector);
    }

    public void ResetBall() 
    {   
        if (isOriginal) {
            Destroy(ballClone);
            ball.SetActive(true);
            arrow.enabled = true;
        }

    }
    void Update()
    {
        if (!isOriginal)
        {
            Vector3 direction = _rb.velocity;
            float speed = 9f;//direction.magnitude;
            direction.Normalize();
            _rb.velocity = direction * speed;
        }
    }
}
