﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helper : MonoBehaviour
{
    public float speed;
    public bool vertical;
    public float changeTime = 3.0f;

    Rigidbody2D rigidbody2D;
    float timer;
    int direction = 1;
     void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;
    }
     void Update()
    {
        timer -= Time.deltaTime;
        if (timer <0)
        {
            direction = -direction;
            timer = changeTime;
        }

        Vector2 position = rigidbody2D.position;
        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
        }
            rigidbody2D.MovePosition(position);
    }
}
