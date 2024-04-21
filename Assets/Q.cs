using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Q : MonoBehaviour
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
        feedbackText.text = "Wow! Score: 85";
        retryText.gameObject.SetActive(false);

        Invoke("LoadSceneWithDelay", 3f);
    }

    void LoadSceneWithDelay()
    {
        // Charger la nouvelle sc�ne "T2L1"
        SceneManager.LoadScene("puzzle");
    }
}
