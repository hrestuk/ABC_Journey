using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    [SerializeField] TMP_InputField nameInputField;
    [SerializeField] TMP_InputField ageInputField;

    public void SetName()
    {
        PlayerPrefs.SetString("PlayerName", nameInputField.text);
        PlayerPrefs.Save(); 
    }
    public void SetAge()
    {
        if (int.TryParse(ageInputField.text.Trim(), out int age))
        {
            PlayerPrefs.SetInt("PlayerAge", age);
            PlayerPrefs.Save(); 
        }
        else{
            Debug.Log("Error");
        }
        
    }
}
