using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomCorrect : MonoBehaviour
{
    public static int a = 0;

    public void OnTopButton()
    {

        if (a == 0)
        {
            a++;
            SceneManager.LoadScene("IncorrectScene");
        }
        else if (a == 1)
        {
            a++;
            SceneManager.LoadScene("IncorrectScene2");
        }
        else
        {
            SceneManager.LoadScene("IncorrectScene3");
        }
    }
    /*public void OnTopButton()
    {

        SceneManager.LoadScene("IncorrectScene");

    }*/

    public void OnBottomButton()
    {
        SceneManager.LoadScene("CorrectScene");

    }
}
