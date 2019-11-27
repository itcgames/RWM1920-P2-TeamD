using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBoundaryDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5.8)
        {
            transform.position = new Vector3(transform.position.x, 4, 0);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        else if (transform.position.y > 5.8)
        {
            transform.position = new Vector3(transform.position.x, 4, 0);
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
