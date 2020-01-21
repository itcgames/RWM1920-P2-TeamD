using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private void Start()
    {
        gameObject.AddComponent<BoxCollider2D>();
        transform.localScale = new Vector3(setScale.GUN_SCALE * transform.localScale.x, setScale.GUN_SCALE * transform.localScale.y, 1);
    }

    void Update()
    {
        Vector3 newPosition = transform.position;        
        
        newPosition.x += Mathf.Cos(((transform.rotation.eulerAngles.z + 90) * Mathf.PI) / 180) * setScale.GUN_SCALE;
        newPosition.y += Mathf.Sin(((transform.rotation.eulerAngles.z + 90) * Mathf.PI) / 180) * setScale.GUN_SCALE;
        transform.position = newPosition;
        if (transform.position.y < -10 || transform.position.y > 10 || transform.position.x < -10 || transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Parachute")
        {
			other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Plank")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
