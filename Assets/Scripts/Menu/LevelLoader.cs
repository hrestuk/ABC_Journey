using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
   [SerializeField] private LoadingScreen loadingScreen;

    private void Awake() 
    {
        loadingScreen.ShowLoadingScreen();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(1);
    }

    private void LoadRegistrationScreen()
    {
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
    }
    
    public void CompleteLoading()
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


    
}
