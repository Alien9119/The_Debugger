using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] float vida;
    [SerializeField] float maximoVida;

    private void Start()
    {
        vida = maximoVida;
    }

    public void TomarDaño2(float daño2) // Cambio de nombre del método
    {
        vida -= daño2;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

        public void Curar(int curacion) //Mediante el uso de un ítem, puede recuperar vida
    {
        if((vida + curacion) > maximoVida)
        {
            vida = maximoVida;
        }
        else
        {
            vida += curacion;
        }
    }
}
