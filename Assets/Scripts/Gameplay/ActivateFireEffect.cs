using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFireEffect : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Active");
        }
    }
}
