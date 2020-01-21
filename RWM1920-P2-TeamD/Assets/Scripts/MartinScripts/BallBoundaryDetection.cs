using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBoundaryDetection : MonoBehaviour
{
	public AudioSource gameLossSource;
	public AudioClip gameLossClip;

    // Start is called before the first frame update
    void Start()
    {
		gameLossSource.clip = gameLossClip;
    }

    // Update is called once per frame
    void Update()
    {
		gameLossSource.volume = PlayerPrefs.GetFloat("volume");
		if (transform.position.y < -5.8)
        {
			gameLossSource.Play();
            transform.position = new Vector3(0, 4, 0);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            PlayerPrefs.SetInt("Health", PlayerPrefs.GetInt("Health") - 1);
            print(PlayerPrefs.GetInt("Health"));
        }
        else if (transform.position.y > 5.8)
        {
			gameLossSource.Play();
			transform.position = new Vector3(0, 4, 0);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            PlayerPrefs.SetInt("Health", PlayerPrefs.GetInt("Health") - 1);
            print(PlayerPrefs.GetInt("Health"));
        }
        else if (transform.position.x > 11)
        {
			gameLossSource.Play();
			transform.position = new Vector3(0, 4, 0);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            PlayerPrefs.SetInt("Health", PlayerPrefs.GetInt("Health") - 1);
            print(PlayerPrefs.GetInt("Health"));

        }
        else if (transform.position.x < -11)
        {
			gameLossSource.Play();
			transform.position = new Vector3(0, 4, 0);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            PlayerPrefs.SetInt("Health", PlayerPrefs.GetInt("Health") - 1);
            print(PlayerPrefs.GetInt("Health"));

        }



    }
}
