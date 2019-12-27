using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Play_Button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }


    public void Level1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Home_Page()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void Exit_Button()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

}
