using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueWriter : MonoBehaviour
{
    private static DialogueWriter instance;

    private List<TextWriterSingle> textWriterSingleList;

    private void Awake()
    {
        instance = this;
        textWriterSingleList = new List<TextWriterSingle>();
    }

    public static void AddWriter_Static(TMP_Text uiText, string textToWrite, float timePerCharacter, bool invisibleChar)
    {
        instance.AddWriter(uiText, textToWrite, timePerCharacter, invisibleChar);
    }

    private void AddWriter(TMP_Text uiText, string textToWrite, float timePerCharacter, bool invisibleChar)
    {
        textWriterSingleList.Add(new TextWriterSingle(uiText, textToWrite, timePerCharacter, invisibleChar));
    }

    private void Update()
    {
        for(int i = 0; i < textWriterSingleList.Count; i++)
        {
            bool destroyInstance = textWriterSingleList[i].Update();
            if (destroyInstance)
            {
                textWriterSingleList.RemoveAt(i);
                i--;
            }
        }
    }

    /* Para una instancia de TextWriter**/ 

    public class TextWriterSingle
    {
        private TMP_Text uiText;
        private string textToWrite;
        private int characterIndex;
        private float timePerCharacter;
        private float timer;
        private bool invisibleChar;

        public TextWriterSingle(TMP_Text uiText, string textToWrite, float timePerCharacter, bool invisibleChar)
        {
            this.uiText = uiText;
            this.textToWrite = textToWrite;
            this.timePerCharacter = timePerCharacter;
            this.invisibleChar = invisibleChar;
            characterIndex = 0;
        }
        
        // Regresa true si completo
        public bool Update()
        {
            timer -= Time.deltaTime;
            while (timer <= 0f)
            {
                //Display next character
                timer += timePerCharacter;
                characterIndex++;
                string text = textToWrite.Substring(0, characterIndex);
                if (invisibleChar)
                {
                    text += "<color=#00000000>" + textToWrite.Substring(characterIndex) + "</color>";
                }
                uiText.text = text;

                if (characterIndex >= textToWrite.Length)
                {
                    uiText = null;
                    return true;
                }
            }
            return false;
        }
    }
}
