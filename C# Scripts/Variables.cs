using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float steerSpeed = 1f; 
    // Start is called before the first frame update
    float moveSpeed = 0.01f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Rotate(0, 0, steerSpeed); //Calls the rotation use zed
            transform.Translate(0, moveSpeed, 0); //Calls the car to move forward use the Y-Axis
        //f stands for float use with decimals 
    }
}
