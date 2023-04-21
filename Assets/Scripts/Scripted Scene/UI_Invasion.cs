using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Invasion : MonoBehaviour
{
    public GameObject InvasionTrigger;

    public RawImage DialoguePanelPlayer;
    public RawImage DialoguePanelAI;
    private TMP_Text messageText;

    private bool PlayerDetected;
    private bool x;

    void Start()
    {
        x = true;
        InvasionTrigger = GameObject.Find("Invasion_Trigger");
        messageText = transform.Find("DialogueManager").Find("Character_dialogue").GetComponent<TMP_Text>();
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
        yield return new WaitForSeconds(2f);
        messageText.enabled = true;
        DialoguePanelAI.enabled = true;
        yield return new WaitForSeconds(4f);
        DialoguePanelAI.enabled = false;
        DialoguePanelPlayer.enabled = true;
        yield return new WaitForSeconds(3f);
        DialoguePanelAI.enabled = true;
        DialoguePanelPlayer.enabled = false;
        yield return new WaitForSeconds(5f);
        DialoguePanelAI.enabled = false;
        DialoguePanelPlayer.enabled = true;
        yield return new WaitForSeconds(3f);
        DialoguePanelPlayer.enabled = false;
        messageText.enabled = false;
    }
}
