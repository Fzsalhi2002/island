using UnityEngine;

public class HintCube : MonoBehaviour
{
    // Référence au cube erroné que vous souhaitez masquer
    public GameObject erroneousCube;
    // Référence au texte associé au cube erroné
    public GameObject erroneousText;

    // Méthode appelée lorsque l'utilisateur clique sur le cube d'indice
    private void OnMouseDown()
    {
        // Vérifiez si le cube erroné et le texte associé existent et sont actifs
        if (erroneousCube != null && erroneousCube.activeSelf &&
            erroneousText != null && erroneousText.activeSelf)
        {
            // Désactivez le cube erroné
            erroneousCube.SetActive(false);
            // Désactivez le texte associé
            erroneousText.SetActive(false);
        }
    }
}
