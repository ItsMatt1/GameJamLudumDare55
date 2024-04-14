using System;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public static class AuxAudioManager
{
    public static bool BackButtonPressed = false;
    
}

public class MenuManager : MonoBehaviour
{
    public void Start()
    {
        if (SceneManager.GetActiveScene().name.Equals("MenuScene") && AuxAudioManager.BackButtonPressed == false)
        {
            AudioManager.instance.Play("MenuSong");
        }
    }

    public void PlayGame()
    {
        AudioManager.instance.StopPlaying("MenuSong");
        AudioManager.instance.Play("GameSong");
        SceneManager.LoadScene("CleyScene"); // Load the game scene
    }

    public void OpenOptions()
    {
        SelectedMenu();
        SceneManager.LoadScene("OptionsScene"); // Load the options scene
    }

    public void SelectedMenu()
    {
        AudioManager.instance.Play("SelectMenu");
    }

    public void QuitGame()
    {
        SelectedMenu();
        Debug.Log("Saiu");
        Application.Quit(); // Quit the application
    }

    public void BackButton()
    {
        SelectedMenu();
        AuxAudioManager.BackButtonPressed = true;
        SceneManager.LoadScene("MenuScene");
    }
    
}
