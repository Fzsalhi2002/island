using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class W : MonoBehaviour
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
        feedbackText.text = "Perfect! Score: 25";
        retryText.gameObject.SetActive(false);

        // Appeler la m�thode LoadSceneWithDelay apr�s un d�lai de 3 secondes
        Invoke("LoadSceneWithDelay", 3f);
    }

    // M�thode pour charger la nouvelle sc�ne apr�s un d�lai
    void LoadSceneWithDelay()
    {
        SceneManager.LoadScene("spuzzle");
    }
}
