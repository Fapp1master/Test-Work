using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHero : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D rb;
    private Vector2 movement;
    private void  Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal") * speed, 0f);
    }
    private void FixedUpdate()
    {
        rb.velocity = movement;
    }
}
