using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float degreesPerSec;
    public bool Right = true;
   
    void Start()
    {
    }

    void Update()
    {
        if (Right == true)
        {
            transform.localRotation = NewRotation(-degreesPerSec, Time.deltaTime, transform.localRotation.eulerAngles.z);
        }
        else
        {
            transform.localRotation = NewRotation(degreesPerSec, Time.deltaTime, transform.localRotation.eulerAngles.z);
        }
        
       
    }

    public void ToggleRight()
    {
        if (Right)
        {
            Right = false;
        }
        else
        {
            Right = true;
        }
    }
    public static Quaternion NewRotation(float t_dps, float t_time, float t_angle)
    {
        float rotAmount = t_dps * t_time;
        float currentRot = t_angle;
        return Quaternion.Euler(new Vector3(0, 0, (currentRot + rotAmount)));
    }

}
