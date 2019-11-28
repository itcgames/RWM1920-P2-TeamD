using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartinPipeScript : MonoBehaviour
{
    bool active = false;

    private void Update()
    {
        print(active);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (active)
        {
            if (collision.gameObject.GetComponent<Rigidbody2D>().transform.position.y > this.GetComponent<Transform>().position.y)
            {
                Transform otherObj = collision.gameObject.GetComponent<Rigidbody2D>().transform;
                otherObj.SetPositionAndRotation(new Vector3(otherObj.position.x, otherObj.position.y - this.GetComponent<Renderer>().bounds.size.y - otherObj.GetComponent<Renderer>().bounds.size.y, otherObj.position.z), new Quaternion());
            }
            else if (collision.gameObject.GetComponent<Rigidbody2D>().transform.position.y < this.GetComponent<Transform>().position.y)
            {
                Debug.Log("Upcollision");
                Transform otherObj = collision.gameObject.GetComponent<Rigidbody2D>().transform;
                otherObj.SetPositionAndRotation(new Vector3(otherObj.position.x, otherObj.position.y + this.GetComponent<Renderer>().bounds.size.y + otherObj.GetComponent<Renderer>().bounds.size.y, otherObj.position.z), new Quaternion());
            }
        }
    }

    public void toggleActive()
    {
        if(active)
        {
            active = false;
        }
        else
        {
            active = true;
        } 
    }
}
