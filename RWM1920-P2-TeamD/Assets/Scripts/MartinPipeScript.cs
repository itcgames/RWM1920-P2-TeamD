using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartinPipeScript : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collison happened");
        //if (collision.gameObject.GetComponent<Rigidbody>().transform.position.y > this.GetComponent<Transform>().position.y)
        //{
        //    Transform otherObject = collision.gameObject.GetComponent<Rigidbody>().transform;
        //    otherObject.SetPositionAndRotation(new Vector3(otherObject.position.x, otherObject.position.y - this.GetComponent<Renderer>().bounds.size.y, otherObject.position.z), new Quaternion());
        //}
        //else if (collision.gameObject.GetComponent<Rigidbody>().transform.position.y < this.GetComponent<Transform>().position.y)
        //{
        //    Transform otherObject = collision.gameObject.GetComponent<Rigidbody>().transform;
        //    otherObject.SetPositionAndRotation(new Vector3(otherObject.position.x, otherObject.position.y + this.GetComponent<Renderer>().bounds.size.y + 1.0f, otherObject.position.z), new Quaternion());
        //}

        if(collision.gameObject.GetComponent<Rigidbody2D>().transform.position.y > this.GetComponent<Transform>().position.y)
        {
            Transform otherObj = collision.gameObject.GetComponent<Rigidbody2D>().transform;
            otherObj.SetPositionAndRotation(new Vector3(otherObj.position.x, otherObj.position.y - this.GetComponent<Renderer>().bounds.size.y - otherObj.GetComponent<Renderer>().bounds.size.y, otherObj.position.z), new Quaternion());
        }
        else if(collision.gameObject.GetComponent<Rigidbody2D>().transform.position.y < this.GetComponent<Transform>().position.y)
        {
            Debug.Log("Upcollision");
            Transform otherObj = collision.gameObject.GetComponent<Rigidbody2D>().transform;
            otherObj.SetPositionAndRotation(new Vector3(otherObj.position.x, otherObj.position.y + this.GetComponent<Renderer>().bounds.size.y + otherObj.GetComponent<Renderer>().bounds.size.y, otherObj.position.z), new Quaternion());
        }
    }
}
