using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_StartingConversation : MonoBehaviour
{
    private SpriteRenderer SpriteR;

    void Start()
    {
        SpriteR = GetComponent<SpriteRenderer>();
        StartCoroutine(EventsTimeline());

    }

    IEnumerator EventsTimeline()
    {
        yield return new WaitForSeconds(8f);
        SpriteR.enabled = true;
    }
}
