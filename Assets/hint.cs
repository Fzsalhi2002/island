using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class HintButton : MonoBehaviour, IPointerClickHandler
{
    public GameObject incorrectCube; // Référence au cube erroné à désactiver

    public void OnPointerClick(PointerEventData eventData)
    {
        // Désactive le cube erroné
        if (incorrectCube != null)
        {
            incorrectCube.SetActive(false);
        }
    }
}
