using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (transform.position.x < -10) 
    { 
    transform.position = new Vector3(-10, transform.position.y, transform.position.z); //keeps player clipped to left side
    }
    if (transform.position.x > 10) 
    { 
    transform.position = new Vector3( 10, transform.position.y, transform.position.z); //keeps player clipped to right side
    }

    }
}
