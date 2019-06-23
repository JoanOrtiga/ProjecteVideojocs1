using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogAttack : LogState
{
    private Vector2 playerPosition;
    private PlayerState state;

    private void OnEnable()
    {
        anim.SetBool("attaking", true);
        InvokeRepeating("dmgPlyr", 0f, logModel.timeBetweenDmg);
    }

    private void dmgPlyr()
    {
         state.getDmg(logModel.damage);
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
        if (((Vector2)rb2d.transform.position - playerPosition).SqrMagnitude() > logModel.rangeAttack)
        {
            anim.SetBool("attaking", false);
            GetComponent<LogChase>().enabled = true;
            this.enabled = false;

            CancelInvoke("dmgPlyr");
        }

        base.changeAnim(playerPosition);
    }
}

