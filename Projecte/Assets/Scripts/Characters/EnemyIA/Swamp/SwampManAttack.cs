using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwampManAttack : SwampManState {

    Vector2 playerPosition;

    private void OnEnable()
    {
        anim.SetBool("throwing", true);
        InvokeRepeating("shoot", 0, 0.5f);
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
        if (((Vector2)rb2d.transform.position - playerPosition).SqrMagnitude() < swampManModel.rangeAttack)
        {
            CancelInvoke("shoot");
            GetComponent<SwampManController>().enabled = true;
            this.enabled = false;
        }

        base.changeAnim(playerPosition);
    }

    private void shoot()
    {
        Instantiate(swampManModel.ball, rb2d.transform.position, rb2d.transform.rotation);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            anim.SetBool("throwing", false);
            GetComponent<SwampManController>().enabled = true;
            CancelInvoke("shoot");
            this.enabled = false;
        }
    }
}
