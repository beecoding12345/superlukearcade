using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    // varaible created for to load the level 
    public string levelToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Player hit the portal 1 ");
        //you can load whatever level you tell it to load 
        SceneManager.LoadScene(levelToLoad);
    }



}
