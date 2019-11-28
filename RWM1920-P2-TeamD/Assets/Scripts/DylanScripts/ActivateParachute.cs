using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateParachute : MonoBehaviour
{
	[SerializeField] private GameObject parachute;

	public AudioSource parachuteSource;
	public AudioClip parachuteClip;
	private void Start()
	{
		parachuteSource.clip = parachuteClip;
	}
	// Update is called once per frame
	void Update()
    {
        if(Input.GetKeyDown("space"))
		{
			parachuteSource.Play();
			parachute.SetActive(true);
		}


		parachute.transform.position = gameObject.transform.position + new Vector3(0.0f, 1.2f, 0.0f);

	}
}
