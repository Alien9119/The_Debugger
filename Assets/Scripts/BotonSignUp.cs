using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Autor: Alexis Hern�ndez
 * C�digo del boton de la escena login para ingresar a la pantalla de creaci�n de nuevo usuario
 */


public class BotonSignUp : MonoBehaviour
{
    public void SignUp()
    {
        SceneManager.LoadScene("SignUpScreen");
    }
}
