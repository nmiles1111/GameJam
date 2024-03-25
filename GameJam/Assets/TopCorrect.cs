using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopCorrect : MonoBehaviour
{
    //public static int a;
    public void OnTopButton()
    {
        SceneManager.LoadScene("CorrectScene");

    }

    public void OnBottomButton()
    {

        /*if (a == 0)
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
        }*/
    }

    
}
