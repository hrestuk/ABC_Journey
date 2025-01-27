using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [Tooltip("Enter Theme index and Level index, separated by a comma(From 0 to N) in 'LoadLevel' function. Example: 5,23 ")]
    [SerializeField] LevelData levelData;

    public void LoadLevel(string themeAndLevelIndex)
    {
        string sceneName = levelData.GetSceneName(themeAndLevelIndex);
        Debug.Log(sceneName);
        SceneManager.LoadScene(sceneName);
    }
    
    // NOTE: Switch to PlayerPrefs for saving data
}
