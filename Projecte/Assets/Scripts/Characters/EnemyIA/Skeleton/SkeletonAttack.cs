using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAttack : SkeletonState
{
    private Vector2 playerPosition;
    private PlayerState state;

    private void OnEnable()
    {
     //   anim.SetBool("walking", false);
    //    anim.SetBool("attaking", true);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            playerPosition = collision.GetComponent<Rigidbody2D>().transform.position;
            state = collision.GetComponent<PlayerState>();
        }
    }

    private void FixedUpdate()
    {
        state.getDmg(skeletonModel.damage * Time.fixedDeltaTime);

        if (((Vector2)rb2d.transform.position - playerPosition).SqrMagnitude() > skeletonModel.rangeAttack)
        {
       //     anim.SetBool("attaking", false);
            GetComponent<SkeletonChase>().enabled = true;
            this.enabled = false;
        }

        base.changeAnim(playerPosition);
    }
}
