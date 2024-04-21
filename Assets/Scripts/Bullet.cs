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
        rb= GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;

        // Set the desired z rotation
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z = desiredZRotation;
        transform.eulerAngles = currentRotation;
    }


}
