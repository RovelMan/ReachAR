﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_physics : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector3 _velocity;

    // Use this for initialization
    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
        _velocity = new Vector3(.5f, 0f, .4f);
        _rb.AddForce(_velocity, ForceMode.VelocityChange);
    }

    void OnCollisionEnter(Collision collision){
        ReflectProjectile(_rb, collision.contacts[0].normal);
    }

    private void ReflectProjectile(Rigidbody rb, Vector3 reflectVector)
    {    
        _velocity = Vector3.Reflect(_velocity, reflectVector);
        _rb.velocity = _velocity;
    }
}
