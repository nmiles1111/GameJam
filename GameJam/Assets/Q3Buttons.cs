using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q3Buttons : MonoBehaviour
{
    public void OnTopButton()
    {
        SceneManager.LoadScene("IncorrectScene");

    }

    public void OnBottomButton()
    {
        SceneManager.LoadScene("CorrectScene");

    }
}
