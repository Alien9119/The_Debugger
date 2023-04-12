using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarRotacion : MonoBehaviour
{
    private Vector3 objetivo;

    private SpriteRenderer SpriteRenderer;

    [SerializeField] private Camera camara;
    [SerializeField] private float anguloInicial;
    public float anguloGrados;

    /**
    private Transform barrel;
    private Transform effect;

    int x = 0;
    int y = 0;
    */

    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        /**
        Transform childBarrel = transform.Find("ControladorDisparo");
        Transform childEffect = transform.Find("Gun_fire");

        barrel = childBarrel.GetComponent<Transform>();
        effect = childEffect.GetComponent<Transform>();
        */
    }

    private void Update()
    {
        objetivo = camara.ScreenToWorldPoint(Input.mousePosition);

        float anguloRadianes = Mathf.Atan2(objetivo.y - transform.position.y, objetivo.x - transform.position.x);
        anguloGrados = (180 / Mathf.PI) * anguloRadianes - anguloInicial;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
    }

    void FixedUpdate()
    {
        if (anguloGrados < 80 && anguloGrados > -80)
        {
            SpriteRenderer.flipY = false;
            /**
            if(x == 0)
            {
                effect.position = new Vector3(effect.position.x, (float)(effect.position.y), effect.position.z);
                barrel.position = new Vector3(barrel.position.x, (float)(barrel.position.y), barrel.position.z);
                x = 1;
            }
            */
        }
        else if (anguloGrados > 80 || anguloGrados < -80)
        {
            SpriteRenderer.flipY = true;
            /**if(y == 0)
            {
                effect.position = new Vector3(effect.position.x, (float)(effect.position.y + 0.05), effect.position.z);
                barrel.position = new Vector3(barrel.position.x, (float)(barrel.position.y + 0.05), barrel.position.z);
                y = 1;
            }
            */
        }
    }
}