using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public static DialogueManager instance;
    public Image CharacterIcon;
    public TextMeshProUGUI CharacterName;
    public TextMeshProUGUI DialogueArea;
    private Queue<DialogueLine> LineQ;
    public bool isDialogueActive = false;
    public float TypingSpeed = 0.1f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        LineQ = new Queue<DialogueLine>();
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isDialogueActive && Input.GetKeyDown(KeyCode.E))
        {
            displaynextdialogue();
        }
    }
    public void StartDialogue(Dialogue dialogue)
    {
        isDialogueActive=true;
        animator.Play("Show");
        LineQ.Clear();
        foreach (DialogueLine line in dialogue.dialoguelines) 
        {
            LineQ.Enqueue(line);
        }
        displaynextdialogue();
    }

    public void displaynextdialogue()
    {
        if (LineQ.Count == 0)
        {
            enddialogue();
            return;
        }
        DialogueLine currentline = LineQ.Dequeue();
        CharacterIcon.sprite = currentline.character.icon;
        CharacterName.text = currentline.character.name;
        StopAllCoroutines();
        StartCoroutine(typesentences(currentline));
    }
    IEnumerator typesentences(DialogueLine line)
    {
        DialogueArea.text = "";
        foreach(char character in line.line.ToCharArray())
        {
            DialogueArea.text += character;
            yield return new WaitForSeconds(TypingSpeed);
        }
    }
    public void enddialogue()
    {
        isDialogueActive = false;
        animator.Play("Hide");    }

}
