using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public float moveSpeed = 3f; // Adjust this to control the speed of the monster
    private Rigidbody2D rb;
    private Vector2 movementDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ChooseRandomDirection();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = movementDirection * moveSpeed;
    }

    void ChooseRandomDirection()
    {
        float randomX = Random.Range(-1f, 1f); // Random direction on the x-axis
        float randomY = Random.Range(-1f, 1f); // Random direction on the y-axis

        movementDirection = new Vector2(randomX, randomY).normalized;
    }
}