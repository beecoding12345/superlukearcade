using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    //This will containe the slider component attached to this object
    // slider ia the varible and is in the form of a slider object
    Slider healthBar;

    // This will be the playerhealth component that we can get
    //info about the players health
    //Player player;



    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Slider>();

        //player = FindObjectOfType<Player>();


    }

    // Update is called once per frame
    void Update()
    {
        //created float varaibles 
        //so we can use float division 
       // float currentHealth = player.currentHealth;
        //float maxHealth = player.startingHealth;


        //the slider value should be between 0 and 1,
        //with 0 being empty and 1 being full
        //healthBar.value = currentHealth / maxHealth;


    }
}
