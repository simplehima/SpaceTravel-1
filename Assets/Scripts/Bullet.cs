using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Desired z rotation
    private float desiredZRotation = 1168.042f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;

        // Set the desired z rotation
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z = desiredZRotation;
        transform.eulerAngles = currentRotation;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collided object has an Enemy component
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            // If the collided object is an Enemy, call its TakeDamage method
            enemy.TakeDamage(10); // Pass the damage amount as needed
        }

        // Destroy the bullet when it hits something
        Destroy(gameObject);
    }
}
