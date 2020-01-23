using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject[] keys;
    int neededTrues;
    // Update is called once per frame
    private void Start()
    {
        neededTrues = keys.Length;

       
    }
    void Update()
    {
        int counter = 0;
        foreach (GameObject i in keys)
        {
            if(i.GetComponent<Key>().getCollected())
            {
                counter++;
            }
        }
        if(counter==neededTrues)
        {
          
            Destroy(gameObject);
        }
    }
}
