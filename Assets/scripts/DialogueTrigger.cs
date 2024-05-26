using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueCharacter
{
    public string name;
    public Sprite icon;
}

[System.Serializable]
public class DialogueLine
{
    public DialogueCharacter character;
    [TextArea(3, 10)]
    public string line;
}

[System.Serializable]
public class Dialogue
{
    public List<DialogueLine> dialoguelines = new List<DialogueLine> ();
}

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public void TriggerDialogue()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F) && other.CompareTag("Player"))
        {
            TriggerDialogue();
        }
    }
}
