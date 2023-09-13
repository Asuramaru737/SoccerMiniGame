using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LostBallsScript : MonoBehaviour
{
    public TextMeshProUGUI lostBallsText;
    private int lostBalls;

    void Start()
    {
        lostBalls = 0;
        lostBallsText.text = "Lost balls : " + lostBalls;
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Ball"){
            lostBalls++;
            Destroy(collision.gameObject);
            lostBallsText.text = "Lost balls : " + lostBalls;
        }

        if(lostBalls == 3){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
