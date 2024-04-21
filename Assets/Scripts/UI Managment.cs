using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManagment : MonoBehaviour
{
    private bool isPaused = false; // Flag to track if the game is paused

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnClick2Start()
    {
        SceneManager.LoadScene("Level2");
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }

    public void OnClickPause()
    {
        // Toggle the pause state
        isPaused = !isPaused;

        if (isPaused)
        {
            // Pause the game
            Time.timeScale = 0f;
        }
        else
        {
            // Resume the game
            Time.timeScale = 1f;
        }
    }
}
