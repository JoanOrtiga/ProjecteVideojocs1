using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private bool damaged = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("breakable"))
        {
            other.GetComponent<objecrDestroyer>().Smash();
        }

        if (other.CompareTag("Enemy") && !damaged) 
        {
            other.GetComponent<CharacterState>().recieveDmg(GameManager.instance.playerModel.power);
            damaged = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        damaged = false;
    }
}
