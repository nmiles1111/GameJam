using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q1Buttons : MonoBehaviour
{
    
    public void OnTopButton()
    {
        SceneManager.LoadScene("CorrectScene");

    }

    public void OnBottomButton()
    {
        SceneManager.LoadScene("IncorrectScene");

    }

}