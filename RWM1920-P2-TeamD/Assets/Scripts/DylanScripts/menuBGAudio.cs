﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuBGAudio : MonoBehaviour
{
	public AudioSource menuBGSource;
	public AudioClip menuBGClip;
    // Start is called before the first frame update
    void Start()
    {
		menuBGSource.clip = menuBGClip;
		menuBGSource.Play();
    }

  
}
