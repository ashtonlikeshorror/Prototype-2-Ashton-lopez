using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float xRange = 10;
    public float horizontalInput;
    public float speed = 100f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    horizontalInput = Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    if (transform.position.x < -xRange) 
    { 
    transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); //keeps player clipped to left side
    }
    if (transform.position.x > xRange) 
    { 
    transform.position = new Vector3( xRange, transform.position.y, transform.position.z); //keeps player clipped to right side
    }

    }
}
