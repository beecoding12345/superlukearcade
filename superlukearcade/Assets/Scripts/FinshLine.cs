using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinshLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Made a if collison tag so when the player hits the finish line
        // the game winning screen comes up saysing you have completed the game
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene("GameWinningScreen");
        }




    }
}
