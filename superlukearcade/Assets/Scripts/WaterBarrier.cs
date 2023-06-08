using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterBarrier : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Made a if collison tag so when the player hits the portal 1 in level 1 it loads game level 2 and comes out portal 2.
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene("GameLosingScreen"); // loads the game losing screen once this if statment happens
        }




    }
}
