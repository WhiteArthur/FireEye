﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet02 : MonoBehaviour
{

	
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		transform.position += transform.right * 0.25f;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "GM") //如果碰撞事件的物件標籤名稱
		{
			Destroy(gameObject);
		}
		if (other.gameObject.tag == "Wall")
		{
			Destroy(gameObject);
		}
		if (other.gameObject.tag == "Objects")
		{
			Destroy(gameObject);
		}
		if (other.gameObject.tag == "WallX")
		{
			Destroy(gameObject);
		}
		if (other.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			
		}
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
		if (col.gameObject.tag == "Player")
		{
			Destroy(gameObject);

		}
	}
}
