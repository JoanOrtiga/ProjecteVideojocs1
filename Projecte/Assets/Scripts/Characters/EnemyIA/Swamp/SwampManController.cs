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
        if (runAway)
        {
            Vector2 vl = ((Vector2)rb2d.transform.position - playerPosition).normalized * swampManModel.chaseSpeed * Time.fixedDeltaTime;

            rb2d.velocity = vl;

            if (((Vector2)rb2d.transform.position - playerPosition).SqrMagnitude() > swampManModel.rangeAttack)
            {
                GetComponent<SwampManAttack>().enabled = true;
                this.enabled = false;
            }

            print(vl);


            base.changeAnim(vl);
        }
        else
        {
            rb2d.velocity = Vector2.zero;
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
            runAway = false;
        }
    }
}
