using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipControll : MonoBehaviour
{
    public float force = 100f;
    private Rigidbody2D _rigidbody2D;
    float horizontal; 
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal=Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        
    }
}
