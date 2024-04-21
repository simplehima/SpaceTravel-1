using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Level3Movement : MonoBehaviour
{
    public Transform object1; // Reference to the first GameObject
    public Transform object2; // Reference to the second GameObject

    public float speed = 5f; // Movement speed
    public float rotationSpeed = 45f; // Rotation speed in degrees per second
    public float shakeMagnitude = 0.1f; // Magnitude of the shake effect
    public float shakeSpeed = 10f; // Speed of the shake effect
    public float fadeSpeed = 0.5f; // Speed of the fade effect
    public Text continueText; // Reference to the "To be continued" text
    public Image fadeImage; // Reference to the UI Image for fading

    private bool moveObject1 = true; // Flag to control movement of object1
    private bool rotateObject1 = false; // Flag to control rotation of object1
    private bool moveObject2 = false; // Flag to control movement of object2
    private bool shakeAndDestroyStarted = false; // Flag to track if shake and destroy process started

    void Start()
    {
        fadeImage.color = Color.clear; // Start with fade image fully transparent
    }

    void Update()
    {
        if (moveObject1)
        {
            // Move object1 towards Vector3(-8.18f, -0.43f, 0)
            MoveObject(object1, new Vector3(-8.18f, -0.43f, 0));

            // Check if object1 has reached the target position
            if (object1.position == new Vector3(-8.18f, -0.43f, 0))
            {
                // Stop object1 from moving
                moveObject1 = false;

                // Rotate object1 to the right by 45 degrees
                rotateObject1 = true;
            }
        }

        if (rotateObject1)
        {
            // Rotate object1 to the right by 45 degrees
            RotateObject(object1, -rotationSpeed);

            // Check if object1 has rotated by 45 degrees
            if (Quaternion.Angle(object1.rotation, Quaternion.Euler(0, 0, -90)) < 1f)
            {
                // Stop rotating object1
                rotateObject1 = false;

                // Start moving object2 up
                moveObject2 = true;
            }
        }

        if (moveObject2)
        {
            // Move object2 up towards Vector3(5.33f, 0.3f, 0)
            MoveObject(object2, new Vector3(5.33f, 0.3f, 0));

            // Check if object2 has reached the target position
            if (object2.position == new Vector3(5.33f, 0.3f, 0))
            {
                // Stop object2 from moving
                moveObject2 = false;

                // Start shaking and destroying object1
                if (!shakeAndDestroyStarted)
                {
                    shakeAndDestroyStarted = true;
                    StartCoroutine(ShakeAndDestroy(object1));
                }
            }
        }
    }

    void MoveObject(Transform obj, Vector3 targetPosition)
    {
        // Calculate movement direction
        Vector3 movement = (targetPosition - obj.position).normalized * speed * Time.deltaTime;

        // Move the object
        obj.Translate(movement);
    }

    void RotateObject(Transform obj, float rotationSpeed)
    {
        // Rotate the object to the right
        obj.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }

    IEnumerator ShakeAndDestroy(Transform obj)
    {
        Vector3 startPosition = obj.position;
        float elapsedTime = 0f;
        float shakeDuration = 2f; // Adjust the duration of the shake effect here

        while (elapsedTime < shakeDuration)
        {
            float x = startPosition.x + Random.Range(-shakeMagnitude, shakeMagnitude);
            float y = startPosition.y + Random.Range(-shakeMagnitude, shakeMagnitude);

            obj.position = new Vector3(x, y, startPosition.z);

            elapsedTime += Time.deltaTime * shakeSpeed;
            yield return null;
        }
        // Destroy object1
        Destroy(obj.gameObject);
        // Delay for 2 seconds
        yield return new WaitForSeconds(2f);

        // Fade out the screen
        while (fadeImage.color.a < 1f)
        {
            fadeImage.color += new Color(0, 0, 0, fadeSpeed * Time.deltaTime);
            yield return null;
        }

        // Display "To be continued" text
        continueText.text = "To Be Continued";
        continueText.gameObject.SetActive(true);
    }
}
