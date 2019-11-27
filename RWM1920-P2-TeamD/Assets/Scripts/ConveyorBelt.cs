using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public GameObject belt;
    public Transform endpoint;
    public Transform endpointLeft;
    public Transform endpointRight;
    public float speed;

    void OnTriggerStay2D(Collider2D other)
    {
        other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed * Time.deltaTime);
    }

    public void toggleEndpoint()
    {
        if (endpoint == endpointLeft)
        {
            endpoint = endpointRight;
        }
        else
        { 
            endpoint = endpointLeft;
        }
    }
}
