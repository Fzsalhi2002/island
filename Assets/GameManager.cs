using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Ajoutez ce namespace pour accéder à SceneManager
using TMPro;

public class GameManager : MonoBehaviour
{
    public piceseScript[] allPieces;
    public TextMeshProUGUI messageText;

    void Update()
    {
        bool allPiecesInRightPosition = true;

        foreach (piceseScript piece in allPieces)
        {
            if (!piece.InRightPosition)
            {
                allPiecesInRightPosition = false;
                break;
            }
        }

        if (allPiecesInRightPosition)
        {
            messageText.text = "Nice! Score: 10";
            messageText.gameObject.SetActive(true); // Active le texte
            Invoke("LoadNextScene", 3f); // Appelle la fonction LoadNextScene après 3 secondes
        }
        else
        {
            messageText.gameObject.SetActive(false); // Désactive le texte s'il n'est pas affiché
        }
    }

    void LoadNextScene()
    {
        // Charge la prochaine scène
        SceneManager.LoadScene("Transition1");
    }
}
