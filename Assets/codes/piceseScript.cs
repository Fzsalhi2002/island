using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class piceseScript : MonoBehaviour
{
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;

    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(19f, 37f), Random.Range(9f, -14));
    }
    
    void Update()
    {
        // Exemple de logique pour vérifier si l'objet est à la bonne position
        if (Vector3.Distance(transform.position, RightPosition) < 0.5f)
        {
            if (!Selected && !InRightPosition)
            {
                // Mettez ici le code à exécuter lorsque l'objet est à la bonne position
                transform.position = RightPosition;
                InRightPosition = true;
                GetComponent<SortingGroup>().sortingOrder = 0;
            }
        }
    }
}
