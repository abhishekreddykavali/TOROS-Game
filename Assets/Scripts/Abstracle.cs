using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Abstracle : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Left_Bull" && other.gameObject.tag != "Right_Bull")
            return;
        SceneManager.LoadScene("Game_Over");
    }
}