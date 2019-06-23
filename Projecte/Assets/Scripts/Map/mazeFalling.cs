using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeFalling : CharacterState {

    public float DmgTaken;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        { 
            collision.GetComponent<PlayerState>().getDmg(DmgTaken * Time.deltaTime);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerState>().getDmg(DmgTaken * Time.deltaTime);
        }
    }
}
