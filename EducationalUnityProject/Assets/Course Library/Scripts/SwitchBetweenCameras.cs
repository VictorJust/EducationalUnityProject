using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBetweenCameras : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Switch2"))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        else if (Input.GetButton("Switch1"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
