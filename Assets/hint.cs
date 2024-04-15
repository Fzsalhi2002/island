using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class HintButton : MonoBehaviour, IPointerClickHandler
{
    public GameObject incorrectCube; // R�f�rence au cube erron� � d�sactiver

    public void OnPointerClick(PointerEventData eventData)
    {
        // D�sactive le cube erron�
        if (incorrectCube != null)
        {
            incorrectCube.SetActive(false);
        }
    }
}
