using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play() // varaible for the play button
    {
        SceneManager.LoadScene("GameLevel1"); // changes scene to the game level after clicking tthe play button 
    }

    public void Quit() // variable for quit the game
    {
       Application.Quit();
    }
}

