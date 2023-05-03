using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_Delay : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;

    private float fireRate = 0.4f;
    private float nextFire = 0f;
    
    public bool canShoot;

    void Start()
    {
        canShoot = true;
    }

    private void Update()
    {
        if (canShoot)
        {
            if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
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
