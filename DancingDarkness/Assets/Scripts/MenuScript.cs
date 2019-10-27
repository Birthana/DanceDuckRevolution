using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(2);

    }

    public void enterCredits()
    {
        SceneManager.LoadScene(1);
    }

    public void justQuit()
    {
        Application.Quit();
    }

}
