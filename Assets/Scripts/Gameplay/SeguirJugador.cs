using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SeguirJugador.cs The_Debugger - Benji Brench
public class SeguirJugador : MonoBehaviour
{
    [SerializeField] private Transform objetivo;
    [SerializeField] private float velocidad;

    public bool persiguiendo = true;
    public static SeguirJugador instance;

    private void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    private void Update()
    {
        float anguloRadianes = Mathf.Atan2(objetivo.position.y - transform.position.y, objetivo.position.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - 90;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);

        Vector3 direccion = objetivo.position - transform.position;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, direccion);

        /*if (Vector3.Distance(transform.position, objetivo.position) > 0.5f)
        {
            transform.position = Vector3.MoveTowards(transform.position, objetivo.position, velocidad * Time.deltaTime);
        }*/
        if (persiguiendo)
        {
            transform.position = Vector3.MoveTowards(transform.position, objetivo.position, velocidad * Time.deltaTime);
        }
    }
}


