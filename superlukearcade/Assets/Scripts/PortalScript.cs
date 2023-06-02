using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{

    public string levelToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Player hit the portal 1 ");

        SceneManager.LoadScene(levelToLoad);
    }



}
