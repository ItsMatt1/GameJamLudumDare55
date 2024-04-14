using System;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void Start()
    {
        AudioManager.instance.Play("MenuSong");
    }

    public void PlayGame()
    {
        AudioManager.instance.StopPlaying("MenuSong");
        AudioManager.instance.Play("GameSong");
        SceneManager.LoadScene("CleyScene"); // Load the game scene
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene("OptionsScene"); // Load the options scene
    }

    public void QuitGame()
    {
        Debug.Log("Saiu");
        Application.Quit(); // Quit the application
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
    
}
