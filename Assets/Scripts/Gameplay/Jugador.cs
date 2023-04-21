using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] public float vida;
    [SerializeField] float maximoVida;
    [SerializeField] public BarraDeVida barraVida;

    private void Start()
    {
        vida = maximoVida;
        barraVida.IniciarBarraVida(vida);
    }

    public void TomarDa�o2(float da�o2) // Cambio de nombre del m�todo
    {
        vida -= da�o2;
        barraVida.CambiarVidaActual(vida);
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    
    public void Curar(float curacion) //Mediante el uso de un �tem, puede recuperar vida
    {
        if ((vida + curacion) > maximoVida)
        {
            vida = maximoVida;
        }
        else
        {
            vida += curacion;
        }

        barraVida.CambiarVidaActual(vida);
    }
}
