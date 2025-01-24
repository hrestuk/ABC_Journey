using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetWord : MonoBehaviour
{
    private readonly float fixedWordHeight = 50f;
    private readonly float fixedWordWidth = 40f;
    private RectTransform rectTransform;
    public string targetWord;
    private void Awake() 
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(fixedWordWidth* targetWord.Length, fixedWordHeight);    
    }

    
}


