using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuClick : MonoBehaviour {

	public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    bool isPaused = false;
    public void Pause()
    {
        if(isPaused == false)
        {
            Time.timeScale = 0;
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            isPaused = false;
        }
    }
}
