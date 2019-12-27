using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    static int score;
    static Text screenText;

    void Start()
    {
        screenText = GetComponent<Text>();
        AddScore(0);
    }
	public static void AddScore(int amount)
    {
        score += amount;
        if (screenText)
        {
            screenText.text = "Score : " + score;
        }

    }
    
}
