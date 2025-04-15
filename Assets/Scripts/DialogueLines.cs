using TMPro;
using UnityEngine;

public class DialogueLines : MonoBehaviour
{
    [SerializeField] string[] timelineTextLines;
    [SerializeField] TMP_Text dialogueText;

    int currentLine = 0;
    public void nextDialogueLine()
    {
        currentLine++;
        dialogueText.text = timelineTextLines[currentLine];
    }
}
