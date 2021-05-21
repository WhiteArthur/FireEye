using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject startCover;
    public GameObject level;
    public GameObject set;
    public GameObject Teach;

    bool gameObjectSetactive = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1;
        if (gameObjectSetactive)
        {
            
            if (Input.GetKeyDown("escape"))
            {
                startCover.SetActive(false);
            }
        }
    }
    public void BackCover()
    {
        gameObjectSetactive = true;
    }

    
    public void Level() //關卡選擇Scene
    {
        SceneManager.LoadScene("Level");
    }

    public void quit()
    {
        Application.Quit();
    }
    public void Level1_1() //進入遊戲
    {
            SceneManager.LoadScene("Game1-1");
    }
    public void Level1_2()
    {
        SceneManager.LoadScene("Game1-2");
    }
    public void Level1_3()
    {
        SceneManager.LoadScene("Game1-3");
    }
    public void Level1_4()
    {
        SceneManager.LoadScene("Game1-4");
    }
    public void Level1_5()
    {
        SceneManager.LoadScene("Game1-5");
    }

    public void Level1_6()
    {
        SceneManager.LoadScene("Game1-6");
    }
}
