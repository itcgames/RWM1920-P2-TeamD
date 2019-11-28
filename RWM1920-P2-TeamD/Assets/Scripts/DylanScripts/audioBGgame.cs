using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioBGgame : MonoBehaviour
{
	public AudioSource gameBGSource;
	public AudioClip gameBGClip;
    // Start is called before the first frame update
    void Start()
    {
		gameBGSource.clip = gameBGClip;
		gameBGSource.Play();
    }

   
}
