using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Autor: Alexis Hern�ndez
 * C�digo que vincula el bot�n el el menu que dice "jugar" para empezar el juego
 **/

public class BotonJugar : MonoBehaviour
{
    public void RunGame()
    {
        SceneManager.LoadScene("MainGame");
    }
}
