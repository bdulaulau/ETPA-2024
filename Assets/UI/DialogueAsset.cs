using UnityEngine;

[CreateAssetMenu] //Cr�� un menu, une data base 

public class DialogueAsset : ScriptableObject 
{
    [TextArea(3, 6)]
    public string[] Dialogue;//on cr�e une liste de texte pour �viter la r�p�tition du code


}
