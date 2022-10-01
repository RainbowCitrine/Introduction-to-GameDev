using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage = false; 
    //Add ur rigid bodys and collisions do not forget to set gravity to zero for certain games
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Oof"); 
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package")
        {
            Debug.Log("Packaged Picked Up"); 
            hasPackage = true; 
        }
        if(other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Packaged Devliverd!"); 
            hasPackage = false; 
        }
    }
}
