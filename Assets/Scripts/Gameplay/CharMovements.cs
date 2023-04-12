using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovements : MonoBehaviour
{
    // Velocidad del jugador
    [SerializeField]
    private float velocityY;
    [SerializeField]
    private float velocityX;

    //Acceso a su rigidbody, animador y renderer
    private Rigidbody2D rigb;
    private Animator anim;
    private SpriteRenderer SpriteRenderer;

    private Vector2 velocidad = new Vector2(0, 0);

    public GameObject Gun;

    void Start()
    {
        rigb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        Gun = transform.Find("Revolver").gameObject;
    }

    void FixedUpdate()
    {
        //Controla el movimiento del jugador
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");
        velocidad.y = movVertical * velocityY;
        velocidad.x = movHorizontal * velocityX;
        rigb.velocity = velocidad;

        //Manda variable de velocidad al animador
        anim.SetFloat("movimiento", Mathf.Abs(rigb.velocity.x + rigb.velocity.y));

        //Invertir la direcci�n cuando personaje apunta hacia atras
        float ang = Gun.GetComponentInChildren<CambiarRotacion>().anguloGrados;
        if(ang < 80 && ang > -80)
        {
            SpriteRenderer.flipX = false;
        }
        else if(ang > 80 || ang < -80)
        {
            SpriteRenderer.flipX = true;
        }
    }
}
