using TMPro;
using UnityEngine;

public class DialoguePlayer : MonoBehaviour
{
    public GameObject dialogueBox;
    public DialogueAsset dialogueAsset;
    public TMP_Text dialogueText;
    private int dialogueLineIndex; 
    private void Start()
    {
        dialogueText.text = dialogueAsset.Dialogue[0]; //afficher le premier bloc de dialogue
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)) //quand la touche entrée est utilisé, passe au dialogue suivant
        {
            dialogueLineIndex += 1; //++ c'est équivalent de +=1
            if (dialogueLineIndex < dialogueAsset.Dialogue.Length)
            {
                dialogueText.text = dialogueAsset.Dialogue[dialogueLineIndex];
            }
            else
            {
                dialogueBox.gameObject.SetActive(false); //masquer objet texte
            }
        }
    }
}
