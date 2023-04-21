using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_StartingConversation : MonoBehaviour
{
    public Image StatusBar;
    public Image HP;
    public RawImage DialoguePanelPlayer;
    public RawImage DialoguePanelAI;
    private TMP_Text messageText;

    void Start()
    {
        messageText = transform.Find("DialogueManager").Find("Character_dialogue").GetComponent<TMP_Text>();
        StartCoroutine(EventsTimeline());
    }

    IEnumerator EventsTimeline()
    {
        StatusBar.enabled = false;
        HP.enabled = false;

        yield return new WaitForSeconds(4f);

        DialoguePanelPlayer.enabled = true;

        yield return new WaitForSeconds(3f);

        messageText.enabled = false;
        DialoguePanelPlayer.enabled = false;

        yield return new WaitForSeconds(2f);

        messageText.enabled = true;
        DialoguePanelAI.enabled = true;

        yield return new WaitForSeconds(19f);

        DialoguePanelAI.enabled = false;
        DialoguePanelPlayer.enabled = true;

        yield return new WaitForSeconds(5f);

        DialoguePanelAI.enabled = true;
        DialoguePanelPlayer.enabled = false;

        yield return new WaitForSeconds(6f);

        DialoguePanelAI.enabled = false;
        DialoguePanelPlayer.enabled = true;

        yield return new WaitForSeconds(1f);

        DialoguePanelAI.enabled = true;
        DialoguePanelPlayer.enabled = false;

        yield return new WaitForSeconds(5f);

        DialoguePanelAI.enabled = false;
        DialoguePanelPlayer.enabled = true;

        yield return new WaitForSeconds(1f);

        DialoguePanelAI.enabled = true;
        DialoguePanelPlayer.enabled = false;

        yield return new WaitForSeconds(6f);

        messageText.enabled = false;
        DialoguePanelAI.enabled = false;
        StatusBar.enabled = true;
        HP.enabled = true;
    }
}
