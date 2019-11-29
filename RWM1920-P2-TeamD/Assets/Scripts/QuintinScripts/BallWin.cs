using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallWin : MonoBehaviour
{
	public AudioSource gameWinSource;
	public AudioClip gameWinClip;
	private void Start()
	{
		gameWinSource.clip = gameWinClip;
	}
	void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collision");
        if (other.name == "Ball")
        {
            Scene scene = SceneManager.GetActiveScene();
            if(scene.name == "MainScene")
            {
				gameWinSource.Play();
                SceneManager.LoadScene(2);//level 2
            }
            else if (scene.name == "Level 2")
            {
                gameWinSource.Play();
                SceneManager.LoadScene(5);//credits

            }
        }
    }
}
