using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] float vida;
    [SerializeField] float maximoVida;
    [SerializeField] public BarraDeVida barraVida;
    [SerializeField] public GameObject gun;

    private CharMovements mov;
    private Animator anim;
    private Collider2D charCollider;
    private SpriteRenderer spriteGun;

    public bool isDead;

    private void Start()
    {
        vida = maximoVida;
        barraVida.IniciarBarraVida(vida);
        mov = GetComponent<CharMovements>();
        anim = GetComponent<Animator>();
        charCollider = GetComponent<Collider2D>();
        spriteGun = gun.GetComponentInChildren<SpriteRenderer>();
        isDead = false;
    }

    public void TomarDaño2(float daño2) // Cambio de nombre del método
    {
        vida -= daño2;
        barraVida.CambiarVidaActual(vida);
        if (vida <= 0)
        {
            mov.canMove = false;
            charCollider.enabled = false;
            spriteGun.enabled = false;
            anim.SetTrigger("ded");
            isDead = true;
        }
    }

        public void Curar(int curacion) //Mediante el uso de un ítem, puede recuperar vida
    {
        if((vida + curacion) > maximoVida)
        {
            vida = maximoVida;
        }
        else
        {
            vida += curacion;
        }
        barraVida.CambiarVidaActual(vida);
    }
}
