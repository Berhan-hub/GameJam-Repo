using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Oyuncu hareket hızı

    private Rigidbody2D rb;
    private Animator animator;

    private Vector2 movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Oyuncunun hareket kontrolü
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        movement = new Vector2(moveX, moveY);

        // Oyuncunun animasyon kontrolü
        animator.SetFloat("MoveX", moveX);
        animator.SetFloat("MoveY", moveY);
    }

    private void FixedUpdate()
    {
        // Oyuncunun fiziksel hareketi
        rb.velocity = movement * moveSpeed;
    }
}
