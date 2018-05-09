using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreHandler  {

    // Use this for initialization
    private static int score;
    private static int highscore;


    // Update is called once per frame
    public static int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }

    public static int HighScore
    {
        get
        {
            return highscore;
        }
        set
        {
            highscore = value;
        }
    }
}
