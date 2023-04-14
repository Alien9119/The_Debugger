using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script ENEMIGO from THE_DEBUGGER proyect
public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float daño2; //Hace daño tomando la función de la clase Jugador
    /*
    public GameObject proyectil;

    private void Start()
    {
        StartCoroutine(GeneraDisparo());
    }

    IEnumerator GeneraDisparo()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            GameObject nuevoProyectil = Instantiate(proyectil);
            nuevoProyectil.transform.position = gameObject.transform.position;
            nuevoProyectil.SetActive(true);
        }
    }
    */

    public void TomarDaño(float daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Colisión del enemigo");
        if (other.CompareTag("Player"))
        {
            print("Colisión con el jugador");
            other.GetComponent<Jugador>().TomarDaño2(daño2); // Nuevo
            print("El jugador ha recibido daño");
            Destroy(gameObject);
        }
    }
}
