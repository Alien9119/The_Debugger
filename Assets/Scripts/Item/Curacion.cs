/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Curacion.cs The_Debugger - Benji Brench
public class Curacion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Jugador>().Curar(20);
            Destroy(gameObject);
        }
    }
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Curacion.cs The_Debugger - Benji Brench
public class Curacion : MonoBehaviour
{
    [SerializeField] float cantidadCuracion = 20f; // cantidad de curación que se aplica

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Jugador jugador = other.GetComponent<Jugador>();
            jugador.Curar(cantidadCuracion); // curar al jugador

            // actualizar la barra de vida
            if (jugador.barraVida != null)
            {
                jugador.barraVida.CambiarVidaActual(jugador.vida);
            }

            Destroy(gameObject); // destruir el objeto de curación
        }
    }
}

