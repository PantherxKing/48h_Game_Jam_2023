using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/**
 * This script redirects all the buttons to various scenes or quits the application
 */ 
public class button_handler : MonoBehaviour
{
    public void OnExitButtonPushed() 
    {
        Application.Quit();
    }
    public void OnTitleButtonPushed()
    {
        SceneManager.LoadScene(0);
    }
    public void OnRestartButtonPushed()
    {
        SceneManager.LoadScene(1);
    }
    public void OnPlayButtonPressed() 
    {
        SceneManager.LoadScene(3);
    }

}
