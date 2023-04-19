using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{
    
    /**
     * Autor: Alexis Hdez.
     * Maneja la pausa de la escena mapa
     */

    //Referencia al panel que muestra el menú de Pausa
    public GameObject panelConsola;
    //Estado del juego
    private bool estaDesplegado = false;

    public void ContinuarJuego()      //Click al botón Continuar de el panel
    {
        Desplegar();
    }
    
    public void Desplegar()
    {
        estaDesplegado = !estaDesplegado;
        panelConsola.SetActive(estaDesplegado);
        Time.timeScale = estaDesplegado ? 0 : 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Desplegar();
        }
    }

}
