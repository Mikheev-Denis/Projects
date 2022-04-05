using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown : MonoBehaviour
{
    public Rigidbody2D body;

    public float horizontal;
    public float vertical;

    public float runSpeed;

    public float torqueForce;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        body.AddForce(transform.up * runSpeed);
        body.AddTorque(Input.GetAxis("Horizontal") * torqueForce);
    }


    
}
