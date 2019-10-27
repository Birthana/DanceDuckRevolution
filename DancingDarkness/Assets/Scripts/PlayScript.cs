using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    public AudioSource audioCreak;
    public void PlayGame()
    {
        audioCreak.Play();
        SceneManager.LoadScene(2);
    }
}
