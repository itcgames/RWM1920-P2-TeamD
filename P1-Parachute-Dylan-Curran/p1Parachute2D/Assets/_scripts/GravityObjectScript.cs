using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityObjectScript : MonoBehaviour
{
	public GameObject objectFalling;


    // Update is called once per frame
    void Update()
    {
		objectFalling.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
		gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
		
	}
}
