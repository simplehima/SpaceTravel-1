using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScorePass : MonoBehaviour
{
    public TMP_Text score_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current score from the EnemyMovement class
        int currentScore = EnemyMovement.ScoreValue;

        // Update the text with the current score
        score_text.text = currentScore.ToString();

    }
}
