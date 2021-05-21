using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public GameObject Door1;
    public GameObject Door2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "player")
        {
            Door1.SetActive(false);
            Door2.SetActive(false);
        }
    }
    public void OnTriggerExit2D(Collider2D col2)
    {
        if (col2.gameObject.tag == "player")
        {
            Door1.SetActive(true);
            Door2.SetActive(true);
        }
    }
}
