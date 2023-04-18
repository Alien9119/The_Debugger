using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;

    public bool canShoot;

    void Start()
    {
        canShoot = true;
    }

    private void Update()
    {
        if (canShoot)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Hace la acción del disparo
                Disparar();
            }
        }
    }

    private void Disparar()
    {
        Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
    }
}
