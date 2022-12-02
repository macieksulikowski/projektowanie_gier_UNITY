using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class zad4 : MonoBehaviour
{
    public float speed = 2.0f;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

     private void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(moveH, 0, moveV);
        velocity = velocity.normalized * speed * Time.deltaTime;
        rb.MovePosition(transform.position + velocity);
    }
}
