using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reset : MonoBehaviour
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
                Debug.Log("Derp");
                if (hit.transform.gameObject.tag == "ResetBT")
                {
                    PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score"));
                    Scene scene = SceneManager.GetActiveScene();
                    SceneManager.LoadScene(scene.name);

                }
            }
        }
    }
}
