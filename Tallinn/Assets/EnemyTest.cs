using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest: MonoBehaviour
{
    public GameObject player;
    private int Enemyhp = 20;

    private float moveSpeed = 0.015f;



    

    void Start()
    {
        
        //moveSpeed = Random.Range(0.02f, 0.025f);
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
