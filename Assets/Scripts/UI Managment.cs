using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManagment : MonoBehaviour
{
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
    public void OnClickQuit()
    {
        Application.Quit();
    }
}
