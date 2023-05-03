using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invasion_Trigger : MonoBehaviour
{
    public bool playerDetected;
    private Collider2D collider;

    void Start()
    {
        collider = GetComponent<Collider2D>();
        playerDetected = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerDetected = true;
            collider.enabled = false;
        }
    }
}
