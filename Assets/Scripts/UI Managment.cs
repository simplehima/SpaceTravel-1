using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

    [System.Obsolete]
    public void OnClickStart()
    {
        Application.LoadLevel("Level1");

    }
    public void OnClickQuit()
    {
        Application.Quit();
    }
}
