using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPadd : MonoBehaviour
{

    private float speed = 90;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector2(0, speed) * Time.deltaTime);
    }
}
