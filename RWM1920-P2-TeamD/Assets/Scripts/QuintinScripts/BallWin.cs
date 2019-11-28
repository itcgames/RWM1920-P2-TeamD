using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallWin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Ball")
        {
            Scene scene = SceneManager.GetActiveScene();
            if(scene.name == "MainScene")
            {
                SceneManager.LoadScene(2);//level 2
            }
            else if (scene.name == "Level 2")
            {
                SceneManager.LoadScene(6);//credits
            }
        }
    }
}
