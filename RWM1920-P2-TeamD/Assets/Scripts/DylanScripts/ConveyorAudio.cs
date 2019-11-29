using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorAudio : MonoBehaviour
{
	public AudioSource beltSource;
	public AudioClip beltClip;
    // Start is called before the first frame update
    void Start()
    {
		beltSource.clip = beltClip;
		beltSource.Play();
    }

    
}
