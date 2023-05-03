using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Enemigo.cs The_Debugger - Benji Brench
public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float da�o2; //Hace da�o tomando la funci�n de la clase Jugador

    public void TomarDa�o(float da�o)
    {
        vida -= da�o;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Colisi�n del enemigo");
        if (other.CompareTag("Player"))
        {
            print("Colisi�n con el jugador");
            other.GetComponent<Jugador>().TomarDa�o2(da�o2);
            //Hacer un timer para dar el da�o dependiendo del collider
            print("El jugador ha recibido da�o");
            SeguirJugador.instance.persiguiendo = false;
            //Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        SeguirJugador.instance.persiguiendo = true;

    }
}