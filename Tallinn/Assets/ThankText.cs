using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThankText : MonoBehaviour
{
    public GameObject G1;
    public Text T1;
    public Text T2;
    float alpha = 0.0f;
    float alpha2 = 0.0f;
    float timer;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.0f)
        {
            G1.SetActive(true); 
            alpha += 0.01f;
            T1.color = new Color(0.88f, 0.37f, 0.16f, alpha);
        }
        if (timer >= 2.0f)
        {
            alpha2 += 0.01f;
            T2.color = new Color(1f, 1f, 1f, alpha2);
        }
    }
}
