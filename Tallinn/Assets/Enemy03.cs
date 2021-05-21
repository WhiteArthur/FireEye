using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy03 : MonoBehaviour
{
    public GameObject player;
    public int Enemyhp = 4;

    public float moveSpeed = 4.0f;





    void Start()
    {

        moveSpeed = Random.Range(0.01f, 0.018f);
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
            Enemyhp -= 1;
        }
    }

    public void gameover()
    {

        player.GetComponent<HP>().Gameover();

    }
}
