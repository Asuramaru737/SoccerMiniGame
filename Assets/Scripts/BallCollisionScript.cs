using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallCollisionScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name == "BallGoalDetector"){
            Destroy(this.gameObject);
        }        
    }
}
