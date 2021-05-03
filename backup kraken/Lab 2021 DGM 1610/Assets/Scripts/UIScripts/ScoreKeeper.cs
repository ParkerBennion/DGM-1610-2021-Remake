using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static int Score;
    public Text ScoreText;

    private void Awake()
    {
        Score = 0;
    }

    private void Update()
    {
        ScoreText.text = Score.ToString();
        if (Score > 20 )
        {
            BackupSpawn.bossT = true;
        }
    }
    //makes a score text box sets it to 0 on awake and then make it a string so it can be displayed.
    //see kill script for how points are added
}
