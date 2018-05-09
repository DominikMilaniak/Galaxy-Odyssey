using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public Text scoreText;
    public int score;

    // Use this for initialization
    void Start () {
        scoreText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {

        score = Mathf.RoundToInt(Time.timeSinceLevelLoad * 10);

        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            scoreText.text = score.ToString();
        }
    }

    void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            scoreText.text = ScoreHandler.Score.ToString();

            if (ScoreHandler.Score > ScoreHandler.HighScore)
            {
                ScoreHandler.HighScore = ScoreHandler.Score;
                scoreText.text = "New Highscore: " + ScoreHandler.HighScore + " !";
            }
            else
            {
                scoreText.text = ScoreHandler.Score.ToString();
            }

        }
        else
        {
            //scoreText.text = score.ToString();
        }
    }

    void OnDestroy()
    {
        ScoreHandler.Score = score;
    }


}
