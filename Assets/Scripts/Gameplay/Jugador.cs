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

    public void TomarDaño2(float daño2) // Cambio de nombre del método
    {
        vida -= daño2;
        barraVida.CambiarVidaActual(vida);
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    
    public void Curar(float curacion) //Mediante el uso de un ítem, puede recuperar vida
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
