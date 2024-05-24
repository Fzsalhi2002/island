using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ControleurK : MonoBehaviour
{
    public float vitesse;
    public Text countText;
    public Text winText;
    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 mouvement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(mouvement * vitesse);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cible"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 5)
        {
            winText.text = "Wow! Score: 55";
            Invoke("LoadNextScene", 3f); // Appelle la méthode LoadNextScene après 3 secondes
        }
    }

    void LoadNextScene()
    {
        // Charge la prochaine scène avec l'index 1 (à changer selon vos besoins)
        SceneManager.LoadScene("DemoJ");
    }
}
