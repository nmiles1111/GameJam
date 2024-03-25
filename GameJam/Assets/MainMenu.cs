using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public AudioSource audio;

    public void OnPlayButton()
    {
        SceneManager.LoadScene("InstructionScreen");

    }

    public void OnQuitButton()
    {
        Application.Quit();

    }

    public void OnMenuButton()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void OnNextButton()
    {
        SceneManager.LoadScene("Q1Scene");

    }

    //public void playNoise()
    //{
    //    audio.Play();
    //}
}
