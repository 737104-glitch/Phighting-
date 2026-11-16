using UnityEngine;
using TMPro;

public class TestScript : MonoBehaviour
{

    public HyperlaserDialogue dialogue;

    [SerializeField] TextMeshProUGUI dialogueText;
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] GameObject dialoguePanel;

    public void ShowDialogue(string dialogue, string name)
    {
        nameText.text = name + "...";
        dialogueText.text = dialogue;
        dialoguePanel.SetActive(true);
    }

    public void EndDialogue()
    {
        nameText.text = null;
        dialogueText.text = null; ;
        dialoguePanel.SetActive(false);
    }

}
