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

    void OnTriggerEnter2D(Collider2D other)
    {
        {

			other.gameObject.SetActive(false);
            Debug.Log("OnTriggerEnter2D");
        }
		Debug.Log("OnTriggerEnter2D123");
	}
}
