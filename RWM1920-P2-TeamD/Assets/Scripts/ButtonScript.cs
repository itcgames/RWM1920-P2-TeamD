using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.transform != null)
            {
                if(hit.transform.gameObject.tag == "NewGame")
                {
                    SceneManager.LoadScene(4);
                }
                if (hit.transform.gameObject.tag == "Options")
                {
                    SceneManager.LoadScene(4);
                }
                if (hit.transform.gameObject.tag == "Quit")
                {
                    Application.Quit();
                }
            }
        }
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(3);
    }
}
