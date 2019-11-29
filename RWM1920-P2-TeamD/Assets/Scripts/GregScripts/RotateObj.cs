using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    float speedLeft = 150.0f;
    float speedRight = -150.0f;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.forward * speedLeft * Time.deltaTime);
            
        } 
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.forward * speedRight * Time.deltaTime);

        }
    }

    public void rotate90()
    {
        transform.Rotate(0, 0, 180);
    }
}