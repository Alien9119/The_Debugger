using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala : MonoBehaviour
{
    private Vector3 escala = new Vector3 ( 0, 0, 1 );
    void Start()
    {
        gameObject.transform.localScale = escala;
    }

    void Update()
    {
        if(escala.x < 1)
        {
            escala.x += 0.01f;
            escala.y += 0.01f;
            gameObject.transform.localScale = escala;
        }
        gameObject.transform.Rotate(0, 0, 5);
    }
}
