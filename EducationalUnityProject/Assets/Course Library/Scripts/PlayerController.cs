using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputID;
    void Start()
    {
        
    }

    private float speed = 20.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardlInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardlInput = Input.GetAxis("Vertical" + inputID);
        // Moves the forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardlInput);
        // Rotates the vehicle based on horizontal input 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
