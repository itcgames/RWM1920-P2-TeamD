using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBehaviour : MonoBehaviour
{
    //public playerBehaviour player;   //declare Script here

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.transform != null)
            {
                //player.printName();   // Call Script function here
                printName(hit.transform.gameObject);
            }
        }
    }

    private void printName(GameObject go)
    {
        print(go.name);
    }
}
