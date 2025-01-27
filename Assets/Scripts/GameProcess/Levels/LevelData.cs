using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LevelData 
{
    public List<Theme> themes;
    private int themeIndex;
    private int levelIndex;
    private string themeAndLevelIndex;

    public string GetSceneName(string newThemeAndLevelIndex)
    {
        themeAndLevelIndex = newThemeAndLevelIndex;
        ParseIndexes();
        return themes[themeIndex].name + " " + themes[themeIndex].levels[levelIndex].name; 
    }

    private void ParseIndexes()
    {
        string[] indexes = themeAndLevelIndex.Split(',');
        themeIndex = int.Parse(indexes[0].Trim());
        levelIndex = int.Parse(indexes[1].Trim());
    }

    // NOTE: Switch to PlayerPrefs for saving data
    // NOTE: Switch to PlayerPrefs for saving data

}
