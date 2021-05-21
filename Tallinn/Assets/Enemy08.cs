﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy08 : MonoBehaviour
{
    public GameObject player;
    public int Enemyhp = 10;

    public float moveSpeed = 4.0f;



    

    void Start()
    {
        
        moveSpeed = Random.Range(0.015f, 0.025f);
        player = GameObject.Find("Player");

    }

    void Update()
    {
        transform.LookAt(player.transform.position);
        transform.position += transform.forward * moveSpeed;
        transform.rotation = Quaternion.Euler(0, 180, 0);

        Enemyhp.ToString();
        gameover();

        if (Enemyhp <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Enemyhp -= 3;
        }
        if (other.gameObject.tag == "ObjectsN")
        {
            Enemyhp -= 1;
        }
    }

    public void gameover()
    {

        player.GetComponent<HP>().Gameover();

    }
}
