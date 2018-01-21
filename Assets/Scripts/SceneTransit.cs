using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransit : MonoBehaviour {



    public void Game()
    {
        SceneManager.LoadScene("Game");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("Splash Screen");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadingScreen()
    {
        SceneManager.LoadScene("Loading Screen");
    }
}
