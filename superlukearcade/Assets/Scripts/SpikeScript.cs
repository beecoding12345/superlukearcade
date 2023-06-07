using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Made a if collison tag so when the player hits the spike 1 even you lose the game and it loads the game losing screen
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene("GameLosingScreen");
        }




    }
}
