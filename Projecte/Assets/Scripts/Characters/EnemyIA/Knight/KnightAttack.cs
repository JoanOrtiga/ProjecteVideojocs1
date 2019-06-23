using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAttack : KnightState {

    private Vector2 playerPosition;
    private PlayerState state;

    private void OnEnable()
    {
        anim.SetBool("attaking", true);
        InvokeRepeating("dmgPlyr", 0f, knightModel.timeBetweenDamage);
    }

    private void dmgPlyr()
    {
        state.getDmg(knightModel.damage);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerPosition = collision.GetComponent<Rigidbody2D>().transform.position;
            state = collision.GetComponent<PlayerState>();
        }
    }

    private void FixedUpdate()
    {
        if (((Vector2)rb2d.transform.position - playerPosition).SqrMagnitude() > knightModel.rangeAttack)
        {
            anim.SetBool("attaking", false);
            GetComponent<KnightChase>().enabled = true;
            this.enabled = false;

            CancelInvoke("dmgPlyr");
        }

        base.changeAnim(playerPosition);
    }
}
