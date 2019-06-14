using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != "Player")
        {
            if (collision.tag == "Enemy")
            {
                collision.GetComponent<CharacterState>().recieveDmg(GameManager.instance.featherDmg);
            }

            if(!collision.isTrigger)
                Destroy(gameObject);
        }

    }
}