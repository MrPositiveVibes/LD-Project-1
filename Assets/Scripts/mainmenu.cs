using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        global Application.Quit();
        Debug.Log("Game closed");
    }

    public void StartGame()
    {
         global SceneManager.LoadScene("Level1");
    }

}