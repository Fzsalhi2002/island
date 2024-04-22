using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    private float timer = 0f;
    public float timeUntilScreenTurnsBlack = 5f; // Temps en secondes avant que l'�cran ne devienne noir

    void Update()
    {
        timer += Time.deltaTime;

        // V�rifie si le temps �coul� d�passe le d�lai sp�cifi�
        if (timer >= timeUntilScreenTurnsBlack)
        {
            // �cran devient noir
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            Screen.autorotateToPortrait = false;
            Screen.autorotateToPortraitUpsideDown = false;
            Screen.autorotateToLandscapeLeft = false;
            Screen.autorotateToLandscapeRight = false;
            Screen.orientation = ScreenOrientation.AutoRotation;
            Camera.main.backgroundColor = Color.black; // Change la couleur de fond de la cam�ra principale en noir
        }
    }
}
