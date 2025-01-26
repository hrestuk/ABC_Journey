using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Awake() 
    {
        if (string.IsNullOrEmpty(PlayerPrefs.GetString("PlayerName")))
        {
            LoadRegistrationScreen();
        }
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void LoadRegistrationScreen()
    {
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
    }
}
