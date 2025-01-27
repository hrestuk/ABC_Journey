using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Awake() 
    {
        PlayerPrefs.DeleteAll();
        if (string.IsNullOrEmpty(PlayerPrefs.GetString("PlayerName")))
        {
            LoadRegistrationScreen();
        }
    }

    private void LoadRegistrationScreen()
    {   
        if (SceneManager.GetActiveScene().buildIndex != SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
        }
    }
    
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
