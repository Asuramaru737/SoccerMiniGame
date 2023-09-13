using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject[] ballPrefab;
    private float spawnRate = 2f;

    void Start()
    {
        StartCoroutine(BallSpawn());
    }

    IEnumerator BallSpawn(){
        while(true){
            var range = Random.Range(-1.82f, 1.48f);
            var position = new Vector2(range, transform.position.y);
            GameObject gameObject = Instantiate(ballPrefab[Random.Range(0, ballPrefab.Length)],
            position, Quaternion.identity);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
