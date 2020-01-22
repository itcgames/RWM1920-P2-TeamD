using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityObjectScript : MonoBehaviour
{
	public GameObject objectFalling;
	Vector3 temp = new Vector3(0, 0,0);
	bool fallNow = false;
	// Update is called once per frame
	void Update()
    {
		if (this.gameObject.activeSelf == true)
		{
			
			gameObject.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);

			//if(temp.y != objectFalling.transform.position.y && temp.y - objectFalling.transform.position.y < 0)
			//{
			//	Debug.Log("fall now pls");
			//	objectFalling.GetComponent<Rigidbody2D>().gravityScale = -0.00f;
			//}
			//Debug.Log(temp.y - objectFalling.transform.position.y);
			//if (!fallNow)
			//{
			//	//objectFalling.GetComponent<Rigidbody2D>().gravityScale = -0.1f;
			//	//Debug.Log("NO");
			//}
			//else
			//{
			//	objectFalling.GetComponent<Rigidbody2D>().gravityScale = 0.0f;
			//	Debug.Log("yes");
			//}
			//objectFalling.GetComponent<Rigidbody2D>().gravityScale = -0.0f;
			//temp = (objectFalling.transform.position);
			
			objectFalling.GetComponent<Rigidbody2D>().velocity = new Vector3(objectFalling.GetComponent<Rigidbody2D>().velocity.x * .98f, objectFalling.GetComponent<Rigidbody2D>().velocity.y * .98f, 0);
			objectFalling.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
			temp = objectFalling.transform.position;
		}
		else
		{
			objectFalling.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
		}
		
	}
}
