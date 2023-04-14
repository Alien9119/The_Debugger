using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script ENEMIGO from THE_DEBUGGER proyect
public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float da�o2; //Hace da�o tomando la funci�n de la clase Jugador
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
            other.GetComponent<Jugador>().TomarDa�o2(da�o2); // Nuevo
            print("El jugador ha recibido da�o");
            Destroy(gameObject);
        }
    }
}
