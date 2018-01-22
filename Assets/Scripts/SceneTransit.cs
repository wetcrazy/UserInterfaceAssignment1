using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransit : MonoBehaviour {

    public void RunLevel(Text levelID)
    {
        if (levelID.text == "Level 1")
            SceneManager.LoadScene("Game");

        else if (levelID.text == "Level 2")
            SceneManager.LoadScene("Level2");

        else if (levelID.text == "Level 3")
            SceneManager.LoadScene("Level3");
    }


    public void Game()
    {
        SceneManager.LoadScene("Game");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level3");
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
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadingScreen()
    {
        SceneManager.LoadScene("Splash Screen");
    }

    public void Pause()
    {
        SceneManager.LoadScene("Pause");
    }

    public void Upgrades()
    {
        SceneManager.LoadScene("Upgrades");
    }
}
