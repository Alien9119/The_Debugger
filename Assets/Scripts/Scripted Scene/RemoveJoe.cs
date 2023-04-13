using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveJoe : MonoBehaviour
{
    private SpriteRenderer SpriteR;

    void Start()
    {
        SpriteR = GetComponent<SpriteRenderer>();
        StartCoroutine(EventsTimeline());
    }
    IEnumerator EventsTimeline()
    {
        yield return new WaitForSeconds(2f);
        SpriteR.flipX = true;
        yield return new WaitForSeconds(2f);
        SpriteR.flipX = false;
        yield return new WaitForSeconds(5f);
        SpriteR.enabled = false;
    }

}
