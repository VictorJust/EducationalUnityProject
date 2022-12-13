using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OngoingVehicleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float speed = 7.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
