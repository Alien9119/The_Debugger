using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Autor: Alexis Hernández
 * Código del boton de la escena signup para volver a la pantalla login
 */


public class VolverLogin : MonoBehaviour
{
    public void volver_a_login()
    {
        SceneManager.LoadScene("LogInScreen");
    } 
}
