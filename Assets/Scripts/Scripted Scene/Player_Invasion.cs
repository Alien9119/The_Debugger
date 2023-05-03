using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Invasion : MonoBehaviour
{

    public GameObject Gun;
    public GameObject InvasionTrigger;

    private Disparo_Delay shootScript;
    private CharMovements moveScript;
    public ActivateFireEffect effectScript;

    private bool PlayerDetected;
    private bool x;

    void Start()
    {
        x = true;
        InvasionTrigger = GameObject.Find("Invasion_Trigger");
        shootScript = GetComponentInChildren<Disparo_Delay>();
        moveScript = GetComponent<CharMovements>();
    }

    void Update()
    {
        PlayerDetected = InvasionTrigger.GetComponent<Detector>().playerDetected;
        if (PlayerDetected)
        {
            if (x)
            {
                StartCoroutine(EventsTimeline());
            }
            x = false;
        }
    }

    IEnumerator EventsTimeline()
    {
        moveScript.canMove = false;
        shootScript.canShoot = false;
<<<<<<< Updated upstream
        yield return new WaitForSeconds(7f);
=======
        effectScript.canShoot = false;
        yield return new WaitForSeconds(17f);
>>>>>>> Stashed changes
        moveScript.canMove = true;
        shootScript.canShoot = true;
        effectScript.canShoot = true;
    }
}
