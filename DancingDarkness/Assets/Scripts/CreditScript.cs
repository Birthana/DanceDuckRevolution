using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScript : MonoBehaviour
{
    public AudioSource audioCreak;
    // Start is called before the first frame update
    public void Back(){
        //audioCreak.Play();
        SceneManager.LoadScene(0);
    } 

    public void Credits()
    {
        audioCreak.Play();
        SceneManager.LoadScene(1);
    }
}
