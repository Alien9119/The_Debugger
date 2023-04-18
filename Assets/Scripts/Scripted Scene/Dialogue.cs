using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    private Queue<string> messages;
    private float[] seconds;
    private float[] velocity;
    private TMP_Text messageText;

    void Awake()
    {
        seconds = new float[13] { 5, 3, 5, 5, 6, 5, 2, 4, 1, 3, 2, 1, 2 };
        velocity = new float[13] { 0.06f, 0.06f, 0.05f, 0.05f, 0.04f, 0.05f, 0.06f, 0.05f, 0.04f,
        0.05f, 0.04f, 0.03f, 0.05f};
        messages = new Queue<string>();
        messageText = transform.Find("Character_dialogue").GetComponent<TMP_Text>();
    }

    void Start()
    {
        StartCoroutine(EventsTimeline());
    }

    IEnumerator EventsTimeline()
    {
        yield return new WaitForSeconds(4f);
        messages.Enqueue("Uh? Donde estoy?");
        messages.Enqueue("Bienvenido al Proyecto Debugger");
        messages.Enqueue("Soy la Inteligencia Artificial DI designada a ayudarte");
        messages.Enqueue("Has entrado a un mundo digital dentro de la web");
        messages.Enqueue("Tu trabajo es buscar y destruir a los bugs que estan interfiriendo con tu sistema");
        messages.Enqueue("Que?! Espera un momento, yo nunca acepte a hacer esto");
        messages.Enqueue("De hecho si lo hiciste");
        messages.Enqueue("Se detallo en los terminos y condiciones que leiste y aceptaste");
        messages.Enqueue("Demonios..");
        messages.Enqueue("No te preocupes mucho, el trabajo puede ser divertido");
        messages.Enqueue("Mientras te mantengas con vida");
        messages.Enqueue("Eh??");
        messages.Enqueue("En fin aqui esta tu equipamiento");

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
