using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityObjectScript : MonoBehaviour
{
	public GameObject objectFalling;


    // Update is called once per frame
    void Update()
    {
		if (this.gameObject.activeSelf == true)
		{
			gameObject.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
			objectFalling.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
			gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
		}
		
	}
}
