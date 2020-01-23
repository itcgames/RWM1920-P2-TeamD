﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartinPipeScript : MonoBehaviour
{
    bool active = false;
	public AudioSource pipeSource;
	public AudioClip pipeClip;
    public Sprite pipeOpen;
    public Sprite pipeClosed;
    private void Start()
	{
        SpriteRenderer spriteR;
        spriteR = GetComponent<SpriteRenderer>();
        spriteR.sprite = pipeClosed;
        pipeSource.clip = pipeClip;
	}
	private void Update()
    {
		pipeSource.volume = PlayerPrefs.GetFloat("volume");
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (active)
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

    public void toggleActive()
    {
        if(active)
        {
            active = false;
            SpriteRenderer spriteR;
            spriteR = GetComponent<SpriteRenderer>();
            spriteR.sprite = pipeClosed;
        }
        else
        {
            SpriteRenderer spriteR;
            spriteR = GetComponent<SpriteRenderer>();
            spriteR.sprite = pipeOpen;
            active = true;
        } 
    }
}
