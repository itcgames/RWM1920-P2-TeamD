﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardVelocityMartin : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x - 0.1f, gameObject.transform.position.y);
    }
}