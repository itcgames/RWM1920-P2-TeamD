using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityInvert : MonoBehaviour {
    private Rigidbody2D Rb;
    public static double invertVal=2;
    int rounded;
    void OnTriggerStay2D(Collider2D other)
    {
        rounded = Mathf.RoundToInt((float)invertVal);
        Rb = other.gameObject.GetComponent<Rigidbody2D>();
        Rb.AddForce(-rounded*(Physics.gravity) * Rb.mass);
        Debug.Log(invertVal);
    }
}
