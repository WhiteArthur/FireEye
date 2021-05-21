using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown2 : MonoBehaviour
{
    float timer_f = 60.0f;
    int timer_i = 0;
    public Text t1;
    public GameObject gameover;
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Gameover();
        t1.text = timer_i.ToString();
        timer_i = (int)timer_f;

        
    }
    public void Gameover()
    {
        timer_f -= Time.deltaTime;
        if (timer_f <= 0f)
        {
            gameover.SetActive(true);
            anim.SetTrigger("die");
            Time.timeScale = 0;
        }
    }
}
