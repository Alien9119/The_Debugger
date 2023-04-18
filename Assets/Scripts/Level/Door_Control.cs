using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Autor: Alexis Hernández
 * Controlador que maneje si la puerta esta abierta o carrada
 */

public class Door_Control : MonoBehaviour
{
    public GameObject Player;
    public GameObject Barrier;
    public GameObject OverLair;

    private Animator anim;
    private Collider2D myCollider;
    private Collider2D playerCollider;
    private Collider2D barrierCollider;
    private SpriteRenderer wallSprite;

    void Start()
    {
        OverLair = transform.Find("Door Opened 2").gameObject;
        Barrier = transform.Find("Player_collider").gameObject;
        anim = gameObject.GetComponent<Animator>();
        myCollider = GetComponent<Collider2D>();
        playerCollider = Player.GetComponent<Collider2D>();
        barrierCollider = Barrier.GetComponentInChildren<Collider2D>();
        wallSprite = OverLair.GetComponentInChildren<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("Close", false);
            anim.SetBool("Open", true);
            barrierCollider.enabled = false;

            StartCoroutine(Delay());
        }
    }
    
    void Update()
    {
        if(!myCollider.IsTouching(playerCollider))
        {
            anim.SetBool("Open", false);
            anim.SetBool("Close", true);
            wallSprite.enabled = false;
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.31f);
        wallSprite.enabled = true;
    }
}