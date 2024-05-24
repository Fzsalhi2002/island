using UnityEngine;

public class HintCube : MonoBehaviour
{
    // R�f�rence au cube erron� que vous souhaitez masquer
    public GameObject erroneousCube;
    // R�f�rence au texte associ� au cube erron�
    public GameObject erroneousText;

    // M�thode appel�e lorsque l'utilisateur clique sur le cube d'indice
    private void OnMouseDown()
    {
        // V�rifiez si le cube erron� et le texte associ� existent et sont actifs
        if (erroneousCube != null && erroneousCube.activeSelf &&
            erroneousText != null && erroneousText.activeSelf)
        {
            // D�sactivez le cube erron�
            erroneousCube.SetActive(false);
            // D�sactivez le texte associ�
            erroneousText.SetActive(false);
        }
    }
}
