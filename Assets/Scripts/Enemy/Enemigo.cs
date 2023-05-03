using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Enemigo.cs The_Debugger - Benji Brench
public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float daño2; //Hace daño tomando la función de la clase Jugador

    private Enemy_Spawning enemySpawning;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    public void TomarDaño(float daño)
    {
        vida -= daño;
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
        print("Colisión del enemigo");
        if (other.CompareTag("Player"))
        {
            print("Colisión con el jugador");
            other.GetComponent<Jugador>().TomarDaño2(daño2);
            //Hacer un timer para dar el daño dependiendo del collider
            print("El jugador ha recibido daño");
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