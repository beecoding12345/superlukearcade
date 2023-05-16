using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinningScreen : MonoBehaviour
{
    public void ReturnToMainMenu() // varaible for main menu button 
    {
        SceneManager.LoadScene("MainMenu"); // this button returns to the main menu after you win the game 
    }
    public void RestartGame() // varaible for the restart button
    {
        SceneManager.LoadScene("GameLevel1"); // this button restarts the game and returns you back to the start of level 1
    }
}


    
