﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relick1Pickup : MonoBehaviour {

   

    // Use this for initialization
    void Start ()
    {
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           other.GetComponent<PlayPickupRelicInvetory>().relic_bible = true;
       
            Destroy(gameObject);
           
        }
    }
}
