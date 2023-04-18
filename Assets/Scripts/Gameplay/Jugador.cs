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

    public void TomarDa�o2(float da�o2) // Cambio de nombre del m�todo
    {
        vida -= da�o2;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

        public void Curar(int curacion) //Mediante el uso de un �tem, puede recuperar vida
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
