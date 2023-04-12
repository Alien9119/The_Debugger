using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**

Autor: Alexis
Autor: Roberto Mtz
 

public class WeaponAim : MonoBehaviour
{
    private Vector3 objetivo;

    [SerializeField] private Camera camara;
    [SerializeField] private float anguloInicial;

    private void Update()
    {
        objetivo = camara.ScreenToWorldPoint(Input.mousePosition);

        float anguloRadianes = Mathf.Atan2(objetivo.y - transform.position.y, objetivo.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - anguloInicial;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
    }
}
*/