using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{

    private void Awake() 
    {
        if (string.IsNullOrEmpty(PlayerPrefs.GetString("PlayerName")))
        {
            LoadRegistrationScreen();
        }
        else
        {
            LoadMenu();
        }
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(1);
    }

    private void LoadRegistrationScreen()
    {
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
    }
    
}
