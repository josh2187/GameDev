﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeedX : MonoBehaviour
{
    private float speed = 7;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
