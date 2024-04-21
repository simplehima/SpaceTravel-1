using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerMovement : MonoBehaviour
{
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetKey(KeyCode.D))
        {


            transform.Translate(Vector2.right * 6 * Time.deltaTime);


        }

        if (Input.GetKey(KeyCode.A))
        {


            transform.Translate(Vector2.left * 6 * Time.deltaTime);



        }        
        if (Input.GetKey(KeyCode.W))
        {


            transform.Translate(Vector2.up * 6 * Time.deltaTime);


        }

        if (Input.GetKey(KeyCode.S))
        {


            transform.Translate(Vector2.down * 6 * Time.deltaTime);
    


        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Atrd" || collision.tag == "border")
        {
            
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");



        }

    }











}
