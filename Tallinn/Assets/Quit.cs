using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public GameObject G1;
    void Awake()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            
            Time.timeScale = 0;
            G1.SetActive(true);
        }
        
    }

    public void chscene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void close()
    {
        Time.timeScale = 1;
        G1.SetActive(false);
    }
}

