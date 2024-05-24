using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class ControleurJoueurV : MonoBehaviour {
public float vitesseV;
public Text countVText;
public Text winVText;
private Rigidbody rbV;
private int countV;
void StartV ()
{
rbV = GetComponent <Rigidbody> ();
countV =0;
SetCountVText ();
winVText.text = "";
}
void FixedUpdateV ()
{
float moveHorizontalV = Input.GetAxis ("Horizontal");
float moveVerticalV = Input.GetAxis ("Vertical");
Vector3 mouvementV = new Vector3 (moveHorizontalV, 0.0f, moveVerticalV);
rbV.AddForce (mouvementV * vitesseV);
}
void OnTriggerEnterV (Collider otherV)
{if (otherV.gameObject.CompareTag ( "Cible"))
{
otherV.gameObject.SetActive (false);
countV = countV + 1;
SetCountVText ();
}
}
void SetCountVText ()
{
countVText.text = "Count: " + countV.ToString ();
if (countV >= 5)
{
winVText.text = "Congrats!";
}
}
}