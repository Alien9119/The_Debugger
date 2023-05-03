using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFireEffect : MonoBehaviour
{
    private Animator anim;

    private float fireRate = 0.4f;
    private float nextFire = 0f;

    public bool canShoot;

    void Start()
    {
        canShoot = true;
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (canShoot)
        {
            if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                anim.SetTrigger("Active");
            }
        }
    }
}
