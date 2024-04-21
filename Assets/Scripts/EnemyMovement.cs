using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public TMP_Text score_text;
    public int score;
    public AudioSource Audio_SFX;
    public static int ScoreValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = score.ToString();
        ScoreValue = score;

        if (score == 60)
        {

            Application.LoadLevel("Level2");
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Atrd")
        {
            Audio_SFX.Play();
            score++;
            Destroy(collision.gameObject);

        }
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);

        }
    }
}
