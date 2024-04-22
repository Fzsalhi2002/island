using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    private float timer = 0f;
    public float timeUntilScreenTurnsBlack = 5f; // Temps en secondes avant que l'écran ne devienne noir

    void Update()
    {
        timer += Time.deltaTime;

        // Vérifie si le temps écoulé dépasse le délai spécifié
        if (timer >= timeUntilScreenTurnsBlack)
        {
            // Écran devient noir
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            Screen.autorotateToPortrait = false;
            Screen.autorotateToPortraitUpsideDown = false;
            Screen.autorotateToLandscapeLeft = false;
            Screen.autorotateToLandscapeRight = false;
            Screen.orientation = ScreenOrientation.AutoRotation;
            Camera.main.backgroundColor = Color.black; // Change la couleur de fond de la caméra principale en noir
        }
    }
}
