using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNameChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("parachute").GetComponentInChildren<TextMesh>().text = "parachute";
        GameObject.Find("PauseButton").GetComponentInChildren<TextMesh>().text = "";

    }

}
