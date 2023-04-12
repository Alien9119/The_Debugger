using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Autor: Alexis Hernández
 * Código que vincula el botón el el menu que dice "jugar" para empezar el juego
 **/

public class BotonJugar : MonoBehaviour
{
    public void RunGame()
    {
        SceneManager.LoadScene("MainGame");
    }
}
