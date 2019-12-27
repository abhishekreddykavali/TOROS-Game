using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Abstracle_2: MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Grass_1" && other.gameObject.tag != "Grass_2")
            return;
        SceneManager.LoadScene("Game_Over");
    }
}