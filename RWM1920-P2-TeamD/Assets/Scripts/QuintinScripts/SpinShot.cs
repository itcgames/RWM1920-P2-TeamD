using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinShot : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.rotation = Quaternion.Euler(0, 0, gameObject.transform.eulerAngles.z - Time.timeScale);
    }
}
