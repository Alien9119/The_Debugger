using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingConversation : MonoBehaviour
{
    public GameObject Gun;
    
    private CharMovements moveScript;
    private SpriteRenderer SpriteBody;
    private SpriteRenderer SpriteGun;

    private bool x;

    void Start()
    {
        x = true;
        moveScript = GetComponent<CharMovements>();
        SpriteBody = GetComponent<SpriteRenderer>();
        SpriteGun = Gun.GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(x)
        StartCoroutine(EventsTimeline());
    }

    IEnumerator EventsTimeline()
    {
        SpriteBody.enabled = false;
        SpriteGun.enabled = false;
        moveScript.canMove = false;
        yield return new WaitForSeconds(9f);
        SpriteBody.enabled = true;
        yield return new WaitForSeconds(3f);
        SpriteGun.enabled = true;
        yield return new WaitForSeconds(3f);
        moveScript.canMove = true;
        x = false;
    }
}
