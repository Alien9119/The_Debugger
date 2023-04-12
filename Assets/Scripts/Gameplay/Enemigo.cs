using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;

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

    public void TomarDa�o(float da�o)
    {
        vida -= da�o;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
