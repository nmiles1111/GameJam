using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class AnswerScripts : MonoBehaviour
{
    public static int c = 0;
    public void OnNextQuestionButton()
    {
        //c++;
        if (c == 0)
        {
            c++;
            SceneManager.LoadScene("Q2Scene");
        }
        else if (c == 1)
        {
            c++;
            SceneManager.LoadScene("Q3Scene");
        }
        else if (c == 2)
        {
            c++;
            SceneManager.LoadScene("Q4Scene");
        }
        else if (c == 3)
        {
            c++;
            SceneManager.LoadScene("Q5Scene");
        }
        else if (c == 4)
        {
            c++;
            SceneManager.LoadScene("Q6Scene");
        }
        else if (c == 5)
        {
            c++;
            SceneManager.LoadScene("Q7Scene");
        }
        else if (c == 6)
        {
            c++;
            SceneManager.LoadScene("Q8Scene");
        }
        else if (c == 7)
        {
            c++;
            SceneManager.LoadScene("Q9Scene");
        }
        else if (c == 8)
        {
            c++;
            SceneManager.LoadScene("Q10Scene");
        }
        else
        {
            SceneManager.LoadScene("WinScene");
        }

        //c++;
    }

    


}
