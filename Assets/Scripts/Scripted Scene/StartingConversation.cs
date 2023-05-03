using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingConversation : MonoBehaviour
{
    public GameObject Gun;

    private Disparo_Delay shootScript;
    private CharMovements moveScript;
    public ActivateFireEffect effectScript;
    private SpriteRenderer SpriteBody;
    private SpriteRenderer SpriteGun;

    void Start()
    {
        shootScript = GetComponentInChildren<Disparo_Delay>();
        moveScript = GetComponent<CharMovements>();
        SpriteBody = GetComponent<SpriteRenderer>();
        SpriteGun = Gun.GetComponentInChildren<SpriteRenderer>();
        StartCoroutine(EventsTimeline());
    }

    IEnumerator EventsTimeline()
    {
        SpriteBody.enabled = false;
        SpriteGun.enabled = false;
        moveScript.canMove = false;
        shootScript.canShoot = false;
        effectScript.canShoot = false;
        yield return new WaitForSeconds(47f);
        SpriteBody.enabled = true;
        yield return new WaitForSeconds(1f);
        SpriteGun.enabled = true;
        yield return new WaitForSeconds(1f);
        moveScript.canMove = true;
        shootScript.canShoot = true;
        effectScript.canShoot = true;
    }
}
