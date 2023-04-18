using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialImage : MonoBehaviour
{
    private SpriteRenderer SpriteR;

    void Start()
    {
        SpriteR = GetComponent<SpriteRenderer>();
        StartCoroutine(EventsTimeline());
    }

    IEnumerator EventsTimeline()
    {
        yield return new WaitForSeconds(49f);
        SpriteR.enabled = true;
    }
}
