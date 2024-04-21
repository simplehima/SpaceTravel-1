using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public AudioSource Audio_SFX;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Audio_SFX.Play();
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);

        }
    }
}
