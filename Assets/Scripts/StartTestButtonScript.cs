﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// This script will attached to button, and assign button event dynamically.
/// (Because it's a prefab button)
/// </summary>
public class StartTestButtonScript : MonoBehaviour
{
    PlayerManager playerManager;
    void Start()
    {
        buttonSetup(gameObject.GetComponent<Button>());
        playerManager = PlayerManager.Instance;
    }
    void buttonSetup(Button button)
    {
        button.onClick.RemoveAllListeners();
        //Add your new event
        button.onClick.AddListener(() => handleButton(button));
    }

    void handleButton(Button b)
    {
        Debug.Log(b.transform.parent.FindChild("Text").GetComponent<Text>().text);
        playerManager.playerID = b.transform.parent.FindChild("Text").GetComponent<Text>().text;
        Debug.Log("Load test scene or do something...");
        SceneManager.LoadScene("Test");
    }
}