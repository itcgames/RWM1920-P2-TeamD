using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool Collected = false;
    private bool switchDir = false;
    int speed = 5;
    void Update()
    {
        if(gameObject.transform.rotation.eulerAngles.z>5)
        {
            gameObject.transform.rotation.Set(0, 0, 4,0);
            speed *= -1;
        }
        if (gameObject.transform.rotation.eulerAngles.z < -5)
        {
            gameObject.transform.rotation.Set(0, 0, -4, 0);
            speed *= -1;
        }
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Collected == false)
        {
            Collected = true;
            SpriteRenderer spriteR;
            spriteR= GetComponent<SpriteRenderer>();
            spriteR.sprite = null;
        }
    }
    public bool getCollected()
    {
        return Collected;
    }
}
