﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float moveSpeed = 5.0f;
    private SpriteRenderer mySR;

    // Start is called before the first frame update
    void Start()
    {
        mySR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        Move();
    }
    
    
    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate
            (new Vector2(0, moveSpeed) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
            transform.Translate
            (new Vector2(0, -moveSpeed) * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate
            (new Vector2(-moveSpeed, 0) * Time.deltaTime);
            if (mySR != null)
            {
                mySR.flipX = true;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate
            (new Vector2(moveSpeed, 0) * Time.deltaTime);
            if (mySR != null)
            {
                mySR.flipX = false;
            }
        }
    }

}
