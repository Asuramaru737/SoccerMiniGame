using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    void Start()
    {
        score = 0;
        scoreText.text = "Score : " + score;
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Ball"){
            score++;
            Destroy(collision.gameObject);
            scoreText.text = "Score : " + score;
            var rb = this.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
        }
    }
}   
