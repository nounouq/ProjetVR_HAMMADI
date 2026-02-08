using UnityEngine;
using TMPro; // Pour gérer le texte

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    private int score = 0;

    // Cette fonction s'exécute quand un objet touche la cible
    private void OnCollisionEnter(Collision collision)
    {
        // On vérifie si c'est la balle qui a touché la cible
        if (collision.gameObject.name == "Balle") 
        {
            score++;
            scoreText.text = "Score : " + score;
            Debug.Log("Touché ! Score : " + score);
        }
    }
}