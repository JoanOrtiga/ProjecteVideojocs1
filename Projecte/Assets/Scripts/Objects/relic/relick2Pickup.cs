﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relick2Pickup : MonoBehaviour {

   
    // Use this for initialization
    void Start ()
    {
       
    }
	
	// Update is called once per frame
	void Update ()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayPickupRelicInvetory>().relic2 = true;
            
            Destroy(gameObject);
        }
    }
}
