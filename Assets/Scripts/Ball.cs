using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public TMP_Text playerScoreText; 
    private int playerScore = 0; 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name.Contains("Goal"))
        {
            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (collision.gameObject.name.Contains("Enemy Goal"))
        {
            playerScore++;
            playerScoreText.text = playerScore.ToString();
        }
    }
}
