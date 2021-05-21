using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public GameObject player;
    public int maxhp = 6;
    public Text HPtext;
    public GameObject gameover;

    public Animator anim;

    


    void Start()
    {
        player = GameObject.Find("Player");
        

    }

    
    void Update()
    {
        HPtext.text = maxhp.ToString(); //讓UI文字跟數字同步
        Gameover();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            maxhp -= 1;
        }
        if(other.gameObject.tag == "EBullet")
        {
            maxhp -= 1;
        }
        if (other.gameObject.tag == "Objects")
        {
            maxhp -= 1;
        }
        if (other.gameObject.tag == "ObjectsN")
        {
            maxhp -= 1;
        }
        if (other.gameObject.tag == "U0")
        {
            maxhp -= 5;
        }
        if (other.gameObject.tag == "HPadd")
        {
            if(maxhp >= 6)
            {
                maxhp -= 2;
            }
            else if (maxhp >= 5)
            {
                maxhp -= 1;
            }
            maxhp += 2;
            Destroy(other.gameObject);
        }
    }
    

    
    public void Gameover()
    {
        if (maxhp <= 0)
        {
            anim.SetTrigger("die");
            Time.timeScale = 0;
            gameover.SetActive(true);
        }
        /*
        else
        {
            
            Time.timeScale = 1;
            gameover.SetActive(false);
        }
        */
    }
    public void back()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start");
    }
}
