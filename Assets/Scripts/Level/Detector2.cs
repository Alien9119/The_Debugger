using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector2 : MonoBehaviour
{
    public bool playerDetected2;
    private Collider2D detectorCollider2;

    void Start()
    {
        detectorCollider2 = GetComponent<Collider2D>();
        playerDetected2 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerDetected2 = true;
            detectorCollider2.enabled = false;
        }
    }
}
