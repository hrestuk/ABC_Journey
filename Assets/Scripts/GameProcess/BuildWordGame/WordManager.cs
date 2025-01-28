using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordManager : MonoBehaviour
{
    [SerializeField] private Button nextButton;
    [SerializeField] private List<DragAndDrop> letters;
    private void Start() 
    {
        nextButton.interactable = false;
        foreach (DragAndDrop item in letters)
        {
            item.onSnapCompleted += CheckWord;
        }
    }

    public void CheckWord()
    {     
        int correctLetters = 0;
        foreach (var item in letters)
        {
            if (!item.isSnapped) 
                return;
            else
            {
                correctLetters++;
            }
        }   

        if (correctLetters == letters.Count)
        {
            nextButton.interactable = true;
        }
    }


}
