using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiButtons : MonoBehaviour
{
    public float alphaLevel = 0f;
    public GameObject Rejugar;
    public GameObject Salir;
    public GameObject Highscores;


    public void reiniciar()
    {
        distancescript.distance = 0f;
        SceneManager.LoadScene("zaxxon_scene1");
    }
    
    public void salir()
    {
        SceneManager.LoadScene("Night Moon Burst");
    }

    public void highscore()
    {
        SceneManager.LoadScene("SampleScene");
    }
}


