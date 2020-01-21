using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderParachute : MonoBehaviour
{
	[SerializeField] private GameObject parachute;

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag != "Parachute")
		{
			parachute.SetActive(false);
			gameObject.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
			parachute.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
		}

	}

	
}
