using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwampManAttack : SwampManState {

    public float rangeForGizmo;
    Vector2 playerPosition;
    
    private void OnEnable()
    {
        anim.SetBool("walking", false);
        anim.SetBool("throwing", true);

        rb2d.velocity = Vector2.zero;

        if (!IsInvoking("Shoot") && swampManModel.timeBetweenAttacks <= 0)
            InvokeRepeating("shoot", 0, swampManModel.timeBetweenAttacks);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerPosition = collision.GetComponent<Rigidbody2D>().transform.position;
        }
    }

    private void FixedUpdate()
    {
        if (Vector2.Distance(playerPosition, (Vector2)rb2d.transform.position) < swampManModel.rangeAttack)
        {
            timeBetweenAttacksCooldownSecurity = swampManModel.timeBetweenAttacks;
            CancelInvoke("shoot");
            GetComponent<SwampManController>().enabled = true;
            this.enabled = false;
        }


        base.changeAnim(playerPosition - (Vector2)rb2d.transform.position);

        timeBetweenAttacksCooldownSecurity -= Time.fixedDeltaTime;

        if(timeBetweenAttacksCooldownSecurity <= 0 &&!IsInvoking("shoot"))
        {
            InvokeRepeating("shoot", 0, swampManModel.timeBetweenAttacks);
        }
    }

    private void shoot()
    {
        Instantiate(swampManModel.ball, rb2d.transform.position, rb2d.transform.rotation);
    }

    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            anim.SetBool("walking", false);
            anim.SetBool("throwing", false);
            CancelInvoke("shoot");
            GetComponent<SwampManController>().enabled = true;
            this.enabled = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, rangeForGizmo);
    }
}
