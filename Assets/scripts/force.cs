using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    public float mass=200f;

    public Rigidbody ship;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float a = Vector3.Distance(transform.position, ship.position);
        ship.AddForce(mass/a/a*(transform.position-ship.position).normalized);
    }
}
