using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AccountData : MonoBehaviour
{
    [SerializeField] private TMP_Text accountName;
    private void Awake() 
    {
        GetPlayerName();
    }

    public void GetPlayerName()
    {
        accountName.text = PlayerPrefs.GetString("PlayerName");
    }
}
