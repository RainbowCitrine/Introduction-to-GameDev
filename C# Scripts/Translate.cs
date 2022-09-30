using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Rotate(0, 0, 0.1f); //Calls the rotation use zed
            transform.Translate(0, 0.01f, 0); //Calls the car to move forward use the Y-Axis
        //f stands for float use with decimals 
    }
}
