using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    //private Rigidbody2D rigidbody;
    private Enemy_Awareness enemy_Awareness;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        enemy_Awareness = GetComponent<Enemy_Awareness>();
    }
    
    private void Update()
    {
        float zRotation = transform.rotation.eulerAngles.z;

        if(zRotation >= 180 || zRotation <= 0)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }
    }
}
