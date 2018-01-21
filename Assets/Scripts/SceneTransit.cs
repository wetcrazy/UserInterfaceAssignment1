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
        SceneManager.LoadScene("Level Select");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadingScreen()
    {
        SceneManager.LoadScene("Loading Screen");
    }
}
