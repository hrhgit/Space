using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipControll : MonoBehaviour
{
    public float pushforce = 1000f;
    public float turnforce = 100f;
    private Rigidbody rb;
    float horizontal; 
    float vertical;
    public Transform direct;
    private Vector3 direction = Vector3.up;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal=Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 worldDirect =  (direct.position-transform.position).normalized;
        rb.AddForce(worldDirect*pushforce*Time.deltaTime*vertical);
        rb.AddTorque(Vector3.up*turnforce*Time.deltaTime*horizontal);
    }
}
