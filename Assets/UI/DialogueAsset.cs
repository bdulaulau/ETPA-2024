using UnityEngine;

[CreateAssetMenu] //Créé un menu, une data base 

public class DialogueAsset : ScriptableObject 
{
    [TextArea(3, 6)]
    public string[] Dialogue;//on crée une liste de texte pour éviter la répétition du code


}
