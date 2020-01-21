using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ScreenWait : MonoBehaviour
{
    public float timeLimit;
    float timer;
    void Start()
    {
        timer = 0;
    }
    void Update()
    {
        timer  += Time.deltaTime;
        if(timer > timeLimit)
        {
            SceneManager.LoadScene(2);//main menu
        }
    }
}
