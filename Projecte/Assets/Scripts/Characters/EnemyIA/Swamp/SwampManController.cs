using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwampManController : SwampManState
{

    private bool runAway;
    private Vector2 playerPosition;

    private void OnEnable()
    {
        runAway = false;
        anim.SetBool("walking", true);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerPosition = collision.GetComponent<Rigidbody2D>().transform.position;
            runAway = true;
        }
    }

    private void FixedUpdate()
    {
        timeBetweenAttacksCooldownSecurity -= Time.fixedDeltaTime;

        if (runAway)
        {
            Vector2 vl = ((Vector2)rb2d.transform.position - playerPosition).normalized * swampManModel.chaseSpeed * Time.fixedDeltaTime;

            rb2d.velocity = vl;

            if (Vector2.Distance(playerPosition, (Vector2)rb2d.transform.position) >= swampManModel.rangeAttack)
            {
                GetComponent<SwampManAttack>().enabled = true;
                this.enabled = false;
            }

            base.changeAnim(vl);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        runAway = false; 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            anim.SetBool("walking", false);
            runAway = false;
        }
    }
}
