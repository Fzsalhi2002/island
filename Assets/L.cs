using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class    L : MonoBehaviour
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
        feedbackText.text = "Amazing! Score: 65";
        retryText.gameObject.SetActive(false);

        // Appeler la m�thode LoadSceneWithDelay apr�s un d�lai de 3 secondes
        Invoke("LoadSceneWithDelay", 3f);
    }

    // M�thode pour charger la nouvelle sc�ne apr�s un d�lai
    void LoadSceneWithDelay()
    {
        SceneManager.LoadScene("Npuzzle");
    }
}
