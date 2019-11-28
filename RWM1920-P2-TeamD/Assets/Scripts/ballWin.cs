using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballWin : MonoBehaviour
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
                SceneManager.LoadScene(3);//should be level 3 0r credits
            }
        }
    }
}
