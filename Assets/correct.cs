using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Correct : MonoBehaviour
{
    public TextMeshProUGUI feedbackText;
    public TextMeshProUGUI retryText;

    void ClearFeedbackText()
    {
        feedbackText.text = "";
    }

    private void OnMouseDown()
    {
        ClearFeedbackText();
        feedbackText.text = "Bravo!";
        retryText.gameObject.SetActive(false);

        // Appeler la m�thode LoadSceneWithDelay apr�s un d�lai de 3 secondes
        Invoke("LoadSceneWithDelay", 3f);
    }

    // M�thode pour charger la nouvelle sc�ne apr�s un d�lai
    void LoadSceneWithDelay()
    {
        // Charger la nouvelle sc�ne "T2L1"
        SceneManager.LoadScene("puzzle");
    }
}
