using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
public class WeaponAim : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 objetivo;

    [SerializeField] private Camera camara;

    // Update is called once per frame
    private void Update()
    {
        objetivo = camara.ScreenToWorldPoint(Input.mousePosition);

        float anguloRadianes = Mathf.Atan2(objetivo.y - transform.position.y, objetivo.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
    }
}
*/

public class WeaponAim : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 objetivo;

    [SerializeField] private Camera camara;

    [SerializeField] private float anguloInicial;

    // Update is called once per frame
    private void Update()
    {
        objetivo = camara.ScreenToWorldPoint(Input.mousePosition);

        float anguloRadianes = Mathf.Atan2(objetivo.y - transform.position.y, objetivo.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - anguloInicial;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
    }
}
