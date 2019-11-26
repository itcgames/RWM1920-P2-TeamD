using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravInvert : MonoBehaviour
{
    
    private Rigidbody2D Rb;
    public static double invertVal = 2;
    int rounded;
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Got here");
        rounded = Mathf.RoundToInt((float)invertVal);
        Rb = collision.gameObject.GetComponent<Rigidbody2D>();
        Rb.AddForce(-rounded * (Physics.gravity) * Rb.mass);
        Debug.Log(invertVal);
    }
    
}
