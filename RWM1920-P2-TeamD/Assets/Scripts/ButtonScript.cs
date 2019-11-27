using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
                    SceneManager.LoadScene(1);
                }
                if (hit.transform.gameObject.tag == "Options")
                {
                    SceneManager.LoadScene(2);
                }
                if (hit.transform.gameObject.tag == "Quit")
                {
                    Application.Quit();
                    print("Derp");
                }
            }
        }
    }
}
