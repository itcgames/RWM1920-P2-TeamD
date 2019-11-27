using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderParachute : MonoBehaviour
{
	[SerializeField] private GameObject parachute;

	private void OnCollisionEnter2D(Collision2D other)
	{
		print("trigger");
		parachute.SetActive(false);
		
	}

	private void CheckActive()
	{
		if(parachute.activeSelf == false)
		{
			gameObject.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
			parachute.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
		}
	}
}
