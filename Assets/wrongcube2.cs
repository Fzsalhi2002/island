using UnityEngine;
using TMPro;

public class WrongCube2 : MonoBehaviour
{
    public TextMeshProUGUI feedbackText; // R�f�rence au TextMeshPro pour afficher le message

    private void OnMouseDown()
    {
        // Affiche "MAUVAISE REPONSE" dans le TextMeshPro
        feedbackText.text = "Retry!!";
    }
}
