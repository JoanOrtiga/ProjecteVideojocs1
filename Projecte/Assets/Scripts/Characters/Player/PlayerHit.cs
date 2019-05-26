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
            other.GetComponent<objectDestroyer>().Smash();
        }

        if (other.CompareTag("Enemy") && !damaged)
        {
            other.gameObject.GetComponent<CharacterState>().recieveDmg(GameManager.instance.playerModel.swordDmg);
            damaged = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        damaged = false;
    }
}
