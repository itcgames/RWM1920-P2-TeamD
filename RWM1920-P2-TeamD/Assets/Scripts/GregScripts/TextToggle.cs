using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextToggle : MonoBehaviour
{
    GameObject go;
    bool on = false;
    string txt;
    private void Start()
    {
        txt = gameObject.GetComponent<Text>().text;
        gameObject.GetComponent<Text>().text = "";
    }
    public void ShowHideText()
    {
        
        
        gameObject.GetComponent<Text>().text = txt;
      
           
        
    }
    public void disableTxt()
        {
        gameObject.GetComponent<Text>().text = "";
    }
    
}


