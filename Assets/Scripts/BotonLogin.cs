using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Autor: Alexis Hern�ndez
 * C�digo del boton de la escena login para ingresar al men� principal
 */

public class BotonLogin : MonoBehaviour
{
    public void Login()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
