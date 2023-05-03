using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public Disparo_Delay shootScript;

    [SerializeField] private GameObject menuGameOver;

    private GameObject main_Character;
    private Jugador scriptJugador;

    void Start()
    {
        main_Character = GameObject.Find("Main_Character");
        scriptJugador = main_Character.GetComponent<Jugador>();
    }

    void Update()
    {
        if (scriptJugador.isDead)
        {
            shootScript.canShoot = false;
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1.5f);
        menuGameOver.SetActive(true);
    }
}
