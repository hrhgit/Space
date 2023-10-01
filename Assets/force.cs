using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    public float gravit=200;

    public Rigidbody ship;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        ship.AddForce(gravit*(transform.position-ship.position));
    }
}
