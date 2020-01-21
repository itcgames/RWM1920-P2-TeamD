using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileActivateParachute : MonoBehaviour
{
	[SerializeField] private GameObject parachute;

	public AudioSource parachuteSource;
	public AudioClip parachuteClip;
	private void Start()
	{
		parachuteSource.clip = parachuteClip;
	}
	// Update is called once per frame
	void OnMouseOver()
	{
		parachuteSource.volume = PlayerPrefs.GetFloat("volume");
		parachuteSource.Play();
		parachute.SetActive(true);
	

	}
	private void Update()
	{
		parachute.transform.position = gameObject.transform.position + new Vector3(0.0f, 1.0f, 0.0f);

	}
}
