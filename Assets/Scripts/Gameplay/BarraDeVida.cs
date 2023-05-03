using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    private Slider slider;

    //private void Start()
    private void Awake()
    {
        //slider = GetComponent<Slider>();
        slider = GetComponentInChildren<Slider>();
    }

    public void CambiarVidaMaxima(float vidaMaxima)
    {
        Debug.Log("Slider funcionando");
        slider.maxValue = vidaMaxima;
    }

    public void CambiarVidaActual(float cantidadVida)
    {
        slider.value = cantidadVida; 
    }

    public void IniciarBarraVida(float cantidadVida)
    {
        CambiarVidaMaxima(cantidadVida);
        CambiarVidaActual(cantidadVida);
    }
}   
