using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    [SerializeField] TargetWord targetWordComponent;
    [SerializeField] private List<DragAndDrop> letters;
    private void Start() 
    {
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

        if (targetWordComponent == null)
        {
            Debug.LogError("TargetWord component not found on the object.");
            return;
        }
        Debug.Log("ChekWord" + correctLetters+ "   TARG " + targetWordComponent.targetWord.Length);

        if (targetWordComponent.targetWord.Length == correctLetters)
        {
            Debug.Log("Win");
        }
        
    }


}
