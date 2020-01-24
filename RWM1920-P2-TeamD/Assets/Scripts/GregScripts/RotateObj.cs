using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    float speed = 150.0f;
    

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKey("d"))
        {
            rotate();
        } 
        
    }

    public void rotate()
    {
        
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
    

    public void rotate90()
    {
        transform.Rotate(0, 0, 180);
    }
    public static Vector3 Rotate(Vector3 t_vec)
    { 

        return Vector3.Scale(t_vec, (Vector3.forward * Time.deltaTime));
    }
}