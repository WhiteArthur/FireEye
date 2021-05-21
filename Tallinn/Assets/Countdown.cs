using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject image;
    public GameObject image2;
    public GameObject start;
    public GameObject bow;
    public GameObject player;
    public Texture2D changeIamge;
    public Texture2D changeIamgeBack;
    bool clickBool = false;

    float timer_f;
    float timer_g;

    void Start()
    {
        
    }

    void Update()
    {
        if(clickBool)
        {
            timer_f += Time.deltaTime;
            timer_g += Time.deltaTime;
        }
        if (timer_f > 6.5f)
        {

            image.GetComponent<RawImage>().texture = changeIamge;

        }
        if (timer_f > 8.5f)
        {

            image2.SetActive(true);

        }
        if (timer_f > 10.5f)
        {
            bow.SetActive(true);
        }
        if (timer_f > 12.5f)
        {
            bow.SetActive(false);
            player.SetActive(true);
            
        }
        if (timer_g > 13.5f)
        {
            start.SetActive(true);
        }
        if (timer_f > 13.5f && timer_g > 14.5f)
        {
            timer_f = 0f;
            timer_g = 0f;
            clickBool = false;
        }
        if (Input.GetKeyDown("escape"))
        {
            timer_f = 0f;
            timer_g = 0f;
            clickBool = false;
            image.GetComponent<RawImage>().texture = changeIamgeBack;
        }
    }
    
    
    public void  ChangeIamge()
    {
        clickBool = true;
    }
    public void startGame()
    {
        clickBool = true;
    }
}
