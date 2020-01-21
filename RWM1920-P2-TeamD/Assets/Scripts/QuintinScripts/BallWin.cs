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
	private void Update()
	{
		gameWinSource.volume = PlayerPrefs.GetFloat("volume");
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
                PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score") + (200 * PlayerPrefs.GetInt("Health")));
                SceneManager.LoadScene(1);//level 2
            }
            else if (scene.name == "Level 2")
            {
                gameWinSource.Play();
                PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + (200 * PlayerPrefs.GetInt("Health")));
                SceneManager.LoadScene(7);//level3
            }
            else if (scene.name == "Level3")
            {
                gameWinSource.Play();
                SceneManager.LoadScene(8);//level4
            }
            else if (scene.name == "Level4")
            {
                gameWinSource.Play();
                PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + (200 * PlayerPrefs.GetInt("Health")));
                PlayerPrefs.SetInt("Health", 5);
                PlayerPrefs.SetInt("Score", 0);
                SceneManager.LoadScene(5);//credits
            }
        }
    }
}
