using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript : MonoBehaviour
{
    public void RetryGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}