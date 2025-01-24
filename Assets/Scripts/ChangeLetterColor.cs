using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLetterColor : MonoBehaviour
{
    
    [Header("Letter index from 1 to N.\nN - max length of text")]
    
    [SerializeField] private int letterIndex = 0;
    void Start()
    {
        TMP_Text lettersText = GetComponent<TMP_Text>();

        string coloredText = lettersText.text.Substring(0, letterIndex-1) + 
        $"<color=#C063FF>{lettersText.text[letterIndex-1]}</color>" + lettersText.text.Substring(letterIndex);

        lettersText.text = coloredText; 
    }

}
