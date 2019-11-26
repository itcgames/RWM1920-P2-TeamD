using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertToggle : MonoBehaviour {

    Vector2 centrePoint;
    public GameObject Go;
    GravInvert grav;
    

    void Start()
    {
        centrePoint = GetComponent<Renderer>().bounds.center;
       
        grav = Go.GetComponent<GravInvert>();
        



    }
    
    
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag==("Finish"))
        {
            //Debug.Log("col detected");
            if (other.gameObject.transform.position.x <centrePoint.x)
            {
                GravInvert.invertVal = (other.gameObject.transform.position.x - centrePoint.x) ;
            }
            else if (other.gameObject.transform.position.x > centrePoint.x)
            {
                GravInvert.invertVal = ((other.gameObject.transform.position.x - centrePoint.x)) ;
            }
        }
    }
}
