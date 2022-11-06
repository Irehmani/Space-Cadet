using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour { 


   Movement playerMovement;

    // Start is called before the first frame update
    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<Movement>();

        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Obstacle")
        {
            playerMovement.Die();
        }
    }


}

