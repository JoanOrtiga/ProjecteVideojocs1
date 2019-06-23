using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesEnemie : MonoBehaviour {
   

    public float DMG = 100;
    
	// Use this for initialization	
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("DMG");
            collision.GetComponent<PlayerState>().getDmg(DMG);
        }
    }


}
