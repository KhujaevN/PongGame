using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Paddle : MonoBehaviour
{

    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public float movement;
    public Vector3 startPosition;



    void Start()
    {
        startPosition = transform.position;
        
    }
    void Update()
    {
        if (isPlayer1) {
            movement = Input.GetAxisRaw("Vertical");
        }

        else {
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
        
    }

     public void Reset() 
     {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
     } 
}