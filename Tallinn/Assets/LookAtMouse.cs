using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{

    public GameObject bullet;
    public bool reload = true;
    public float reloadTime;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        //滑鼠位置
        Vector3 pt = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);
        //砲台轉向
        Vector3 v = pt - transform.position;  //方向 = 目標- 自己
                                              //Mathf.Atan2(v.y,v.x)得到弧度(圓周率) * Mathf.Rad2Deg (弧度轉角度(360))
        float angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
        //瞬間轉過去
        //transform.rotation = Quaternion.Euler( new Vector3(0,0,angle));

        //慢慢轉過去 用插值 Lerp
        transform.rotation = Quaternion.Lerp(transform.rotation
        , Quaternion.Euler(new Vector3(0, 0, angle)), 0.1f);

        
    }
    void Attack()
    {
        bool click = Input.GetMouseButtonDown(0);
        if (click)
        {
            if (reload)
            {
                reload = false;
                GameObject b = Instantiate(bullet, transform.position, transform.rotation);
                Destroy(b.gameObject, 3.0f);
            }
        }
        if (reload == false)
        {
            reloadTime += Time.deltaTime;
            if (reloadTime > 0.25f)
            {
                reload = true;
                reloadTime = 0f;
            }
        }
    }
    
}
