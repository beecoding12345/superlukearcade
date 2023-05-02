using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLosingScreen : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("GameLevel1");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
