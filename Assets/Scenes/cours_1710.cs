using JetBrains.Annotations;
using TMPro;
using UnityEngine; //Régle d'import, dans ce script on rend ça utilisable 
public class cours_1710 : MonoBehaviour //public = créé un script dispo dans tout le projet, class = un plan
//MonoBehaviour = class de base pour créer des composants custom
{

    public TMP_Text messageText; //référence à cela pour pouvoir l'utiliser
    public TMP_InputField numberInput; //permet de lire ce que le joueur va écrire dans le chm text

    private int randomNumber; // int= type primitif, dans C# de base 

    private void Start() //void = pas de résultat à nous donner, Start = comeback de lifecycle, à appeler à un moment clé du cycle de notre jeu début/fin
    {
        Restart();
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text)) // On teste si il y a que des valeurs vide, retour à la ligne, espace etc etc..
        {
            messageText.text = "Tu es sûr.e de ne pas vouloir répondre correctement ? Attention à toi.";
            numberInput.text = "";
            return; //pour vider le champs de texte du joueur
        }
        if (int.TryParse(numberInput.text, out int playerNumber)) //Lire du texte et va en déduire qqchose, out renvoie une deuxième valeur avec le nombre qu'on a rentré 
        {
            if (playerNumber == randomNumber)
            {
                messageText.text = "Bravo, ah oui toi tu sais trop de chose ..";
                Restart();
                return;
            }
            else if (playerNumber > randomNumber)
            {
                messageText.text = "Un peu moins ..";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "Un peu plus ..";
            }
            else
            {
                messageText.text = "Tu es sûr.e de ne pas vouloir répondre coorectement ? Attention à toi.";
                numberInput.text = "";
                return; //pour vider le champs de texte du joueur

            }
        }

    }
    public void Restart()
    {
        //messageText.text = "Tu as choisi ton destin. Cours.";
        randomNumber = Random.Range(1, 100 + 1);//Range va prendre le minimum et le maximum
        Debug.Log("Nouveau nombre : " + randomNumber);//permet d'afficher dans le debug le nombre 
        messageText.text = "C'est reparti !";
    }
    

}