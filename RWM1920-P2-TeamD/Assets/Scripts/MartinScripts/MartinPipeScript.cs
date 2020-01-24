using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartinPipeScript : MonoBehaviour
{
    public static bool activePipe = false;
	public AudioSource pipeSource;
	public AudioClip pipeClip;
    public static float pipeHeight = 0.9f;
    public static float rotation = 0.0f;
	private void Start()
	{
		pipeSource.clip = pipeClip;
	}
	private void Update()
    {
		pipeSource.volume = PlayerPrefs.GetFloat("volume");
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (activePipe)
        {
			pipeSource.Play();
            if (collision.gameObject.GetComponent<Rigidbody2D>().transform.position.y > this.GetComponent<Transform>().position.y)
            {
				Debug.Log("Downcollision");
				Transform otherObj = collision.gameObject.GetComponent<Rigidbody2D>().transform;
                otherObj.SetPositionAndRotation(new Vector3(otherObj.position.x, otherObj.position.y - this.GetComponent<Renderer>().bounds.size.y - otherObj.GetComponent<Renderer>().bounds.size.y - 0.05f, otherObj.position.z), new Quaternion());
            }
            else if (collision.gameObject.GetComponent<Rigidbody2D>().transform.position.y < this.GetComponent<Transform>().position.y)
            {
                Debug.Log("Upcollision");
                Transform otherObj = collision.gameObject.GetComponent<Rigidbody2D>().transform;
                otherObj.SetPositionAndRotation(new Vector3(otherObj.position.x, otherObj.position.y + this.GetComponent<Renderer>().bounds.size.y + 0.05f + otherObj.GetComponent<Renderer>().bounds.size.y, otherObj.position.z), new Quaternion());
            }
        }
    }

    public static bool getAlive()
    {
        return activePipe;
    }

    public static float getPipeHeight()
    {
        return pipeHeight;
    }

    public static float getRotation()
    {
        return rotation;
    }

    public void toggleActive()
    {
        if(activePipe)
        {
            activePipe = false;
        }
        else
        {
            activePipe = true;
        } 
    }
}
