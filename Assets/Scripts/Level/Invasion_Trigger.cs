using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invasion_Trigger : MonoBehaviour
{
    public bool playerDetected;

    void Start()
    {
        playerDetected = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerDetected = true;
        }
    }
}
