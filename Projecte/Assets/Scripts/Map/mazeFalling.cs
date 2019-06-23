using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeFalling : CharacterState {

    private Transform target;
    public float DmgTaken;

    // Use this for initialization
    void Start ()
    {
        target = GameObject.FindWithTag("Player").transform;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") { 
            target.GetComponent<PlayerState>().getDmg(DmgTaken);
            
        }
    }
}
