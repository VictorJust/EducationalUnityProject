using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerFrontView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject player;
    private Vector3 offset = new Vector3( 0, 3, 0 );
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
