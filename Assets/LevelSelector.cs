using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public string levelSceneName;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(levelSceneName);
    }
}
