using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
            if (hit.transform != null)
            {
                Debug.Log("derp");
                if (hit.transform.gameObject.tag == "MainMenu")
                {
                    SceneManager.LoadScene(3);
                    
                }
                if (hit.transform.gameObject.tag == "HelpMenu")
                {
                    SceneManager.LoadScene(1);

                }
            }
        }
    }
}
