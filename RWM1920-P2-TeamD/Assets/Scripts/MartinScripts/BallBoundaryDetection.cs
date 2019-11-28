using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBoundaryDetection : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y < -5.8)
        {
            transform.position = new Vector3(0, 4, 0);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        else if (transform.position.y > 5.8)
        {
            transform.position = new Vector3(0, 4, 0);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        else if (transform.position.x > 11)
        {
            transform.position = new Vector3(0, 4, 0);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        else if (transform.position.x < -11)
        {
            transform.position = new Vector3(0, 4, 0);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
