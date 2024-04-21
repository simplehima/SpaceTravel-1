using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomMovement : MonoBehaviour
{
    private Camera cam;
    private float minX, maxX, minY, maxY;
    public float moveSpeed = 2f;
    private Vector2 targetPosition;

    void Start()
    {
        cam = Camera.main;

        // Calculate the boundaries of the camera view
        float objectWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2;
        float objectHeight = GetComponent<SpriteRenderer>().bounds.size.y / 2;

        Vector2 lowerLeft = cam.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 upperRight = cam.ViewportToWorldPoint(new Vector2(1, 1));

        minX = lowerLeft.x + objectWidth;
        maxX = upperRight.x - objectWidth;
        minY = lowerLeft.y + objectHeight;
        maxY = upperRight.y - objectHeight;

        // Start moving the object
        SetNewRandomTarget();
    }

    void Update()
    {
        // Move towards the target position
        transform.position = Vector2.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Check if the object has reached close to the target position
        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            // Set a new random target position
            SetNewRandomTarget();
        }
    }

    void SetNewRandomTarget()
    {
        // Generate a random target position within the camera view
        targetPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");

        }

    }
}
