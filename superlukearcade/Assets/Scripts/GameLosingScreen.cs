using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLosingScreen : MonoBehaviour
{
    public void RestartGame() // varaible for restart button 
    {
        SceneManager.LoadScene("GameLevel1"); // this changes the scene back to the game level at the start of level 1 after losing the game
    }

    public void ReturnToMainMenu() // varaible for main menu button
    {
        SceneManager.LoadScene("MainMenu"); // this changes the scene back to the main menu after clickin gth hutton and losing the game
    }
}
