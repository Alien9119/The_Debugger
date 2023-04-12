using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Autor: Alexis Hernández
 * Código del boton de la escena login para ingresar al menú principal
 */

public class BotonLogin : MonoBehaviour
{
    public void Login()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
