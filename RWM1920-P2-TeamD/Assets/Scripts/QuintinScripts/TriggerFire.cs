using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFire : MonoBehaviour
{
    public float gameTimer;
    public bool start;
    public GameObject gun;
    public Vector3 startPos;
    void Start()
    {
        start = false;
        startPos = new Vector3(0,0,0);
    }
    void Update()
    {
        if (Time.timeScale == 1)
        {
            if (gun.transform.localScale.z == -1 && !start)
            {
                start = true;
                gameTimer = 0.0f;
            }
            if (start)
            {
                gameTimer += Time.deltaTime;
                if (gameTimer >= 0.1f && gameTimer < 0.2f)
                {
                    Vector3 newVector;
                    Vector3 newPosition = transform.position;
                    newVector.x = Mathf.Cos(((transform.rotation.eulerAngles.z + 180) * Mathf.PI) / 180);
                    newVector.y = Mathf.Sin(((transform.rotation.eulerAngles.z + 180) * Mathf.PI) / 180);
                    newPosition.x += newVector.x / 45;
                    newPosition.y += newVector.y / 45;
                    transform.position = newPosition;
                }
                else if (gameTimer >= 0.3f && gameTimer < 0.4f)
                {
                    Vector3 newVector;
                    Vector3 newPosition = transform.position;
                    newVector.x = Mathf.Cos(((transform.rotation.eulerAngles.z) * Mathf.PI) / 180);
                    newVector.y = Mathf.Sin(((transform.rotation.eulerAngles.z) * Mathf.PI) / 180);
                    newPosition.x += newVector.x / 45;
                    newPosition.y += newVector.y / 45;
                    transform.position = newPosition;
                }
                else if (gameTimer > 0.6f)
                {
                    start = false;
                    gun.transform.localScale = new Vector3(gun.transform.localScale.x, gun.transform.localScale.y, 1);
                }
            }
            else
            {
                if (gun.transform.eulerAngles.z < 1)
                {
                    if (startPos == new Vector3(0, 0, 0))
                    {
                        startPos = transform.position;
                    }
                    else
                    {
                        transform.position = startPos;
                    }
                }
            }
        }
    }
}
