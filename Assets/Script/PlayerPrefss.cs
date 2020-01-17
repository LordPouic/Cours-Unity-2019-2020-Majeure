using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefss : MonoBehaviour
{
    private Text t;
    private int score = 0;

    void Start()
    {
        t = GetComponent<Text>();
        score = PlayerPrefs.GetInt("BestScore");
    }

    void Update()
    {
        score++;
        t.text = "" + score;

        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetInt("BestScore", score);
        }
    }

    private void OnApplicationQuit()
    {
       //SAUVEGARDE
    }

    private void OnApplicationFocus(bool focus)
    {
        //SAUVEGARDE
    }
}
