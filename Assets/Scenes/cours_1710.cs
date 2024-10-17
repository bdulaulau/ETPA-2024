using TMPro;
using UnityEngine; //R�gle d'import, dans ce script on rend �a utilisable 
public class cours_1710 : MonoBehaviour //public = cr�� un script dispo dans tout le projet, class = un plan
//MonoBehaviour = class de base pour cr�er des composants custom
{

    public TMP_Text messageText; //r�f�rence � cela pour pouvoir l'utiliser
    public TMP_InputField numberInput; //permet de lire ce que le joueur va �crire dans le chm text

    private int randomNumber; // int= type primitif, dans C# de base 

    private void Start() //void = pas de r�sultat � nous donner, Start = comeback de lifecycle, � appeler � un moment cl� du cycle de notre jeu d�but/fin
    {
        //messageText.text = "Tu as choisi ton destin. Cours.";
        randomNumber = Random.Range(1, 100 + 1); //Range va prendre le minimum et le maximum
        Debug.Log("Attention il se passe des trucs chelou, cours mec tu vas mourir. Je d�conne c'est : " + randomNumber); //permet d'afficher dans le debug le nombre 
        messageText.text = "Devine combien de gens sont enterr�s dans mon jardin... ?";
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text)) // On teste si il y a que des valeurs vide, retour � la ligne, espace etc etc..
        {
            messageText.text = "Tu es s�r.e de ne pas vouloir r�pondre correctement ? Attention � toi.";
            numberInput.text = "";
            return; //pour vider le champs de texte du joueur
        }
        if (int.TryParse(numberInput.text, out int playerNumber)) //Lire du texte et va en d�duire qqchose, out renvoie une deuxi�me valeur avec le nombre qu'on a rentr� 
        {

        }
        else
        {
            messageText.text = "Tu es s�r.e de ne pas vouloir r�pondre coorectement ? Attention � toi.";
            numberInput.text = "";
            return; //pour vider le champs de texte du joueur

        }
    }


}