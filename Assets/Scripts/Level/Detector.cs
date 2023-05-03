using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{ 
    public bool playerDetected;
    private Collider2D detectorCollider;

    void Start()
    {
        detectorCollider = GetComponent<Collider2D>();
        playerDetected = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerDetected = true;
            detectorCollider.enabled = false;
        }
    }
}
