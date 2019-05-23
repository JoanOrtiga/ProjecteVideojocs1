using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonChase : SkeletonState {

    private Vector2 dirPoint;

    private void OnTriggerStay2D(Collider2D collision) 
    {
        if(collision.tag == "Player")
        {
            skeleton._speed = skeleton.chaseSpeed;
            rb2D.transform.position = collision.GetComponent<Rigidbody2D>().transform.position; //posició player
        }
    }
}
