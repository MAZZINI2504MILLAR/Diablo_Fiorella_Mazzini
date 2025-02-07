using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogos : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TMP_Text dialogueText;
    private string[] dialogues = { "Hola, viajero.", "Necesito tu ayuda.", "Buena suerte en tu misión." };
    private int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        dialoguePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartDialogue()
    {
        dialoguePanel.SetActive(true);
        dialogueText.text = dialogues[index];
    }
    public void NextDialogue()
    {
        index++;
        if (index < dialogues.Length)
        {
            dialogueText.text = dialogues[index];
        }
        else
        {
            dialoguePanel.SetActive(false);
            index = 0;
        }
    }
}
