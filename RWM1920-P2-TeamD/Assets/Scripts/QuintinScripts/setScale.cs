using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setScale : MonoBehaviour
{
    public float scaleInput;
    public static float GUN_SCALE;
    // Start is called before the first frame update
    void Start()
    {
        GUN_SCALE = scaleInput;
        if(GUN_SCALE == 0)
        {
            GUN_SCALE = 1;
        }
        transform.localScale = new Vector3(GUN_SCALE, GUN_SCALE,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
