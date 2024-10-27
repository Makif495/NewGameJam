using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tiklama : MonoBehaviour
{

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }


    public void AyarButton()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
    public void menuButton()
    {
        SceneManager.LoadScene(0);
    }
}
