using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<CharacterState>().recieveDmg(GameManager.instance.playerModel.power);
            Destroy(gameObject);
        }
    }
}