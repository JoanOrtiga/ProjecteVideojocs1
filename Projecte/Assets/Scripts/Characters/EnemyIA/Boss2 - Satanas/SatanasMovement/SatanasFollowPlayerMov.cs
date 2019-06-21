using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatanasFollowPlayerMov : SatanasMovementController {

    Vector2 playerPos;

	// Use this for initialization
	void Start () {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        rb2d.transform.position = Vector2.MoveTowards(rb2d.transform.position, playerPos, satanModel.speed);
    }
}
