using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float speed = 2f;
    private Rigidbody2D rb;
    private Vector2 moveVector;
    private bool flipped = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;

        //float moveInput = Input.GetAxisRaw("Horizontal");
        if(moveVector.x < 0 && flipped){
            flipped = !flipped;
            transform.Rotate(0,180,0);
        }
        if(moveVector.x > 0 && !flipped){
            flipped = !flipped;
            transform.Rotate(0,180,0);
        }
        //this.transform.rotation = Quaternion.Euler(new Vector2(0f, flipped ? 180f : 0f));
    }

    void FixedUpdate(){
        var movement = moveVector * speed * Time.deltaTime;
        if(moveVector != Vector2.zero){
            this.transform.Translate(new Vector3(movement.x, movement.y), Space.World);
        }
        
    }
}
