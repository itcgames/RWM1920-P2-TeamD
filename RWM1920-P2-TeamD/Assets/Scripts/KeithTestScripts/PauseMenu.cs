using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void ButtonPause()
    {
        if(!GameIsPaused)
        {
            GameIsPaused = true;
            Pause();
        }
        else if(GameIsPaused)
        {
            GameIsPaused = false;
            Resume();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Reset()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Scene scene = SceneManager.GetActiveScene();
        PlayerPrefs.SetInt("Health", 5);
        PlayerPrefs.SetInt("Score", 0);
        SceneManager.LoadScene(scene.name);
    }

    public void GotoMenu()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("Health", 5);
        PlayerPrefs.SetInt("Score", 0);
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Time.timeScale = 0f;
        GameIsPaused = false;
        PlayerPrefs.SetInt("Health", 5);
        PlayerPrefs.SetInt("Score", 0);
        Application.Quit();
    }
}
