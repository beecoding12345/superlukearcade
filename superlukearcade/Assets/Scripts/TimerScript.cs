using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 4f;


    void Start()    // Start is called before the first frame update
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Timer.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            SceneManager.LoadScene("GameLosingScreen");
        }
    }
   
    
    
}
