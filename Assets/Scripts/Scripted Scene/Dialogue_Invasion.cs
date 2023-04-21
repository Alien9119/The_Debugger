using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue_Invasion : MonoBehaviour
{
    public GameObject InvasionTrigger;

    private Queue<string> messages;
    private float[] seconds;
    private float[] velocity;
    private TMP_Text messageText;

    private bool PlayerDetected;
    private bool x;

    void Awake()
    {
        x = true;
        
        seconds = new float[4] { 4, 3, 5, 2 };
        velocity = new float[4] { 0.05f, 0.06f, 0.05f, 0.06f};
        messages = new Queue<string>();

        messageText = transform.Find("Character_dialogue").GetComponent<TMP_Text>();
        InvasionTrigger = GameObject.Find("Invasion_Trigger");
    }

    void Update()
    {
        PlayerDetected = InvasionTrigger.GetComponent<Detector>().playerDetected;
        if (PlayerDetected)
        {
            if(x)
            {
                StartCoroutine(EventsTimeline());
            }
            x = false;
        }
    }

    IEnumerator EventsTimeline()
    {
        yield return new WaitForSeconds(2f);
        messages.Enqueue("Emergencia. Los bugs estan entrando a nuestro sistema");
        messages.Enqueue("Ellos? Wow, son bugs literales");
        messages.Enqueue("Vas a tener que enfrentarlos para evitar que corrompan el sistema");
        messages.Enqueue("Muy bien, veamos lo que tienen!");

        int index = 0;
        int index1 = 0;

        while (messages.Count > 0)
        {
            float textSpeed = velocity[index1];
            string message = messages.Dequeue();
            DialogueWriter.AddWriter_Static(messageText, message, textSpeed, true);
            yield return new WaitForSeconds(seconds[index]);
            index = (index + 1) % seconds.Length;
            index1 = (index1 + 1) % velocity.Length;
        }
    }
}
