using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class ControleurJoueur : MonoBehaviour {
public float vitesse;
public Text countText;
public Text winText;
private Rigidbody rb;
private int count;
void Start ()
{
rb = GetComponent <Rigidbody> ();
count =0;
SetCountText ();
winText.text = "";
}
void FixedUpdate ()
{
float moveHorizontal = Input.GetAxis ("Horizontal");
float moveVertical = Input.GetAxis ("Vertical");
Vector3 mouvement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
rb.AddForce (mouvement * vitesse);
}
void OnTriggerEnter (Collider other)
{if (other.gameObject.CompareTag ( "Cible"))
{
other.gameObject.SetActive (false);
count = count + 1;
SetCountText ();
}
}
void SetCountText ()
{
countText.text = "Count: " + count.ToString ();
if (count >= 5)
{
winText.text = "Wow! Score:15";
}
}
}