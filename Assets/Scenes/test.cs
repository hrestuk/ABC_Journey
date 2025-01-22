using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Button[] letterButtons;  
    [SerializeField] private string targetWord = "HEL";  
    private int currentLetterIndex = 0;  

    void Start()
    {
        SetupButtons();
    }

    void SetupButtons()
    {
        for (int i = 0; i < letterButtons.Length; i++)
        {
            int index = i;
            letterButtons[i].GetComponentInChildren<Text>().text = targetWord[index].ToString();
            letterButtons[i].onClick.AddListener(() => OnLetterClicked(index));
        }
    }

    void OnLetterClicked(int index)
    {
        if (targetWord[index] == targetWord[currentLetterIndex])
        {
            currentLetterIndex++;
            Debug.Log("wwwwww!" + targetWord.Length + " " + currentLetterIndex);
            
            if (currentLetterIndex >= targetWord.Length)
            {
                Debug.Log("Вы выиграли!");
            }
        }
        else
        {
            Debug.Log("Неверная буква!");
        }
    }
}
