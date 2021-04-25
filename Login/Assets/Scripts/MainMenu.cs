using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public void SetupHost()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GetHostCode()
    {
        System.Random random = new System.Random();
        int code = random.Next(1000, 9999);

        // code ^ moet worden weergegeven in scene "Host"
        // in text object "HostCode"
        
    }

    public void SetupClient()
    {
        SceneManager.LoadScene("ClientSetup");
    }

    public void Home()
    {
        SceneManager.LoadScene("SampleScene");
    }

    
}
