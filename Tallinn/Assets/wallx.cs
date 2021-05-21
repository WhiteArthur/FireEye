using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallx : MonoBehaviour
{
    public GameObject wall;
    public Vector3 FF = new Vector3(-0.25f, -0.25f, 0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            transform.localScale += FF;
        }
    }
    
}
