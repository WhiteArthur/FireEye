using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
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
		if (other.gameObject.tag == "Enemy") //如果碰撞事件的物件標籤名稱
		{
			//Destroy(other.gameObject); //刪除碰撞到的物件(Force)
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
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
		if (other.gameObject.tag == "Objects")
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
		if (other.gameObject.tag == "ObjectsN")
		{
			Destroy(gameObject);
		}



	}
}
