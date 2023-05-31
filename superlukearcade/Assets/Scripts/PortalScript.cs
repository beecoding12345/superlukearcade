using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Made a if collison tag so when the player hits the portal 1 in level 1 it loads game level 2 and comes out portal 2.
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene("GameLevel2");
        }

        // Made a if collision tage so when the player runs into the finish line at the end of level 2 then it goes to game winnning screen.
        if (collision. tag == "Player")
        {
            SceneManager.LoadScene("GameWinningScreen");
        }
    }
}
