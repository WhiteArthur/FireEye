﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCover : MonoBehaviour
{
    public GameObject G1;
    public Text T1;

    private float alpha = 0.0f;
    private float timer = 0.0f;
    private bool textBool = false;

    // 暫存
    private float _timeCache = -1;

    // 延遲時間
    private float _stayTime = 5;


    private void Update()
    {
        // 淡入
        if (textBool)
        {
            timer += Time.deltaTime;

            // 最大值 1
            alpha = Mathf.Min(alpha + .01f, 1);
            T1.color = new Color(0f, 0f, 0f, alpha);

            G1.SetActive(true);

            // Mathf.Approximately(A, B) 比對兩個 float 是否相同，可避免二進位誤差
            if (Mathf.Approximately(alpha, 1))
            {
                // 如 _timeCache 為 -1，則計算延遲後的時間
                if (Mathf.Approximately(_timeCache, -1)) _timeCache = timer + _stayTime;

                // 如超過延遲後時間停止
                if (timer >= _timeCache)
                {
                    T1.color = new Color(0f, 0f, 0f, (alpha));
                    textBool = false;
                }
            }
        }

        // 淡出
        if (!textBool)
        {
            timer += Time.deltaTime;

            // 最小值 0
            alpha = Mathf.Max(alpha - .01f, 0);
            T1.color = new Color(0f, 0f, 0f, (alpha));

            // 如淡出完成則重置數值與停止
            if (Mathf.Approximately(alpha, 0))
            {
                timer = 0;
                _timeCache = -1;
                G1.SetActive(false);
            }
        }
    }
    public void buttonBool()
    {
        textBool = true;
    }
}
