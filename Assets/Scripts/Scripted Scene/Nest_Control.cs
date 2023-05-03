using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nest_Control : MonoBehaviour
{
    public Enemy_Spawning spawnScript;
    public GameObject InvasionTrigger;
    public GameObject Child;

    private SpriteRenderer SpriteR;
    private SpriteRenderer SpriteR_Hijo;

    private bool InvT;
    private bool x;

    private float max;

    private Vector3 escala = new Vector3(0, 0, 1);

    void Start()
    {
        x = true;
        max = 1;
        Child = transform.Find("Nest1").gameObject;
        InvasionTrigger = GameObject.Find("Invasion_Trigger");
        SpriteR = GetComponent<SpriteRenderer>();
        SpriteR_Hijo = Child.GetComponentInChildren<SpriteRenderer>();

        gameObject.transform.localScale = escala;
    }

    void Update()
    {
        InvT = InvasionTrigger.GetComponent<Detector>().playerDetected;
        if (InvT)
        {
            if (x)
            {
                SpriteR.enabled = true;
                SpriteR_Hijo.enabled = true;
                StartCoroutine(Delay());
            }
            x = false;
            if (escala.x < max && !spawnScript.spawnerDone)
            {
                escala.x += 0.005f;
                escala.y += 0.005f;
                gameObject.transform.localScale = escala;
            }
            if(escala.x > 0 && spawnScript.spawnerDone)
            {
                escala.x -= 0.007f;
                escala.y -= 0.007f;
                gameObject.transform.localScale = escala;
            }
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(18f);
        max = 2.5f;
    }
}
