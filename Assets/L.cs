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

        // Appeler la méthode LoadSceneWithDelay après un délai de 3 secondes
        Invoke("LoadSceneWithDelay", 3f);
    }

    // Méthode pour charger la nouvelle scène après un délai
    void LoadSceneWithDelay()
    {
        SceneManager.LoadScene("Npuzzle");
    }
}
