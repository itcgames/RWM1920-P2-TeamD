using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeControllerScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, heart4, heart5;
    public Text timeTxt;
    public Text Score;
    public static int health = 5;
    public static float timeLeft = 20;

    private static LifeControllerScript Instance;
    // Start is called before the first frame update

    void Start()
    {
        if (!PlayerPrefs.HasKey("isFirstTime"))
        {
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(true);
            heart4.gameObject.SetActive(true);
            heart5.gameObject.SetActive(true);

            PlayerPrefs.SetInt("Score", 0);
            PlayerPrefs.SetInt("Health", health);
            PlayerPrefs.SetInt("isFirstTime", 1);
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetInt("Health", PlayerPrefs.GetInt("Health"));
            timeLeft = 20;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("Health") > 5)
        {
            PlayerPrefs.SetInt("Health", 5);
        }

        timeLeft -= Time.deltaTime;
        
        if(timeLeft <= 0)
        {
            timeLeft = 20;
            PlayerPrefs.SetInt("Health", PlayerPrefs.GetInt("Health") - 1);
        }

        timeTxt.text = "Time: " + (int)timeLeft;
        Score.text = "Score: " + PlayerPrefs.GetInt("Score");

        switch (PlayerPrefs.GetInt("Health"))
        {
            case 5:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(true);
                break;
            case 4:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(false);
                break;
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                PlayerPrefs.SetInt("Health", 5);
                PlayerPrefs.SetInt("Score", 0);
                SceneManager.LoadScene(9);
                break;
        }
    }
}
