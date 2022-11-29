using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    private float speed = 5.0f;
    private float turnSpeed;
    private float horizontalInput;
    private float forwardlInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardlInput = Input.GetAxis("Vertical");
        // Moves the forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardlInput);
        // Rotates the vehicle based on horizontal input 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
