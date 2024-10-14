using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerController;
using TMPro;
public class PlayerName : MonoBehaviour
{
    public string playerName;
    public TMP_InputField playerNameInput;
    public TMP_Text playerNameDisplay;
    public GameObject nameConfirmButton;

    public void DisplayNewPlayerName()
    {
        playerName = playerNameInput.text;
        playerNameDisplay.text = playerName;
        nameConfirmButton.SetActive(false);
        playerNameInput.gameObject.SetActive(false);
    }
}



