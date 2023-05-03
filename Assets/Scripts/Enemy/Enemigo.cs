using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Enemigo.cs The_Debugger - Benji Brench
public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float da�o2; //Hace da�o tomando la funci�n de la clase Jugador

    private Enemy_Spawning enemySpawning;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    public void TomarDa�o(float da�o)
    {
        vida -= da�o;
        if (vida <= 0)
        {
            StartCoroutine(DeathDelay());
            enemySpawning = FindObjectOfType<Enemy_Spawning>();
            enemySpawning.enemiesInRoom--;
            if(enemySpawning.spawnTime <= 0 && enemySpawning.enemiesInRoom <= 0)
            {
                enemySpawning.spawnerDone = true;
            }
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

    IEnumerator DeathDelay()
    {
        anim.SetTrigger("Muerte");
        yield return new WaitForSeconds(0.7f);
        Destroy(gameObject);
    }
}