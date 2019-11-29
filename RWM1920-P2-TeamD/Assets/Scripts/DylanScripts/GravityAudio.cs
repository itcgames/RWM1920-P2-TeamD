using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAudio : MonoBehaviour
{

	public AudioSource gravitySource;
	public AudioClip gravityClip;
    // Start is called before the first frame update
    void Start()
    {
		gravitySource.clip = gravityClip;
		gravitySource.Play();
    }

	private void Update()
	{
		gravitySource.volume = PlayerPrefs.GetFloat("volume");
	}


}
