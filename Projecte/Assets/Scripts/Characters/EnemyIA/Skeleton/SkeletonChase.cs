using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonChase : SkeletonState {

    private bool chasing;
    private Vector2 playerPosition;

    private void OnEnable()
    {
        chasing = false;
    //    anim.SetBool("walking", true);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            playerPosition = collision.GetComponent<Rigidbody2D>().transform.position;
            chasing = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            chasing = false;
        }
        if(collision.gameObject.tag == "Player")
        {
            GetComponent<SkeletonAttack>().enabled = true;
            this.enabled = false;
        }
    }

    private void FixedUpdate()
    {
        if (chasing)
        {
            rb2d.transform.position = Vector2.MoveTowards(rb2d.transform.position, playerPosition, skeletonModel.chaseSpeed * Time.fixedDeltaTime);

            if (((Vector2)rb2d.transform.position - playerPosition).SqrMagnitude() < skeletonModel.rangeAttack)
            {
                GetComponent<SkeletonAttack>().enabled = true;
                this.enabled = false;
            }

            base.changeAnim(playerPosition);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GetComponent<SkeletonPatrol>().enabled = true;
            this.enabled = false;
        }        
    }
}
