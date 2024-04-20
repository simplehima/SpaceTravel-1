using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerMovement : MonoBehaviour
{
    //public SpriteRenderer spr;
    //public Animator anim;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetKey(KeyCode.D))
        {


            transform.Translate(Vector2.right * 6 * Time.deltaTime);
            //spr.flipX = true;
            //anim.SetBool("run", true);

        }

        if (Input.GetKey(KeyCode.A))
        {


            transform.Translate(Vector2.left * 6 * Time.deltaTime);
            //spr.flipX = false;
            //anim.SetBool("run", true);


        }        
        if (Input.GetKey(KeyCode.W))
        {


            transform.Translate(Vector2.up * 6 * Time.deltaTime);
            //spr.flipX = true;
            //anim.SetBool("run", true);

        }

        if (Input.GetKey(KeyCode.S))
        {


            transform.Translate(Vector2.down * 6 * Time.deltaTime);
            //spr.flipX = false;
            //anim.SetBool("run", true);


        }

            //if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
            //{

            //    anim.SetBool("run", false);


            //}
    }

    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Atrd")
        {
            //Audio_SFX.Play();
            //score++;
            Destroy(collision.gameObject);
            Application.LoadLevel("GameOver");

        }
    }









}
