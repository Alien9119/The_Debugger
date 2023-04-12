using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Autor: Alexis Hernández
 * Código del boton de la escena login para ingresar a la pantalla de creación de nuevo usuario
 */


public class BotonSignUp : MonoBehaviour
{
    public void SignUp()
    {
        SceneManager.LoadScene("SignUpScreen");
    }
}
