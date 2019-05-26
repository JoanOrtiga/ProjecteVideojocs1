using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : EnemyState
{

    private Vector2 dirPoint;

    private void Update()
    {
        if (dirPoint != null)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, dirPoint, enemy.chaseSpeed);
        }       
    }

    private void OnTriggerStay2D(Collider2D collision) 
    {
        if(collision.tag == "Player")
        {
            dirPoint = collision.transform.position;
            

            if (Vector2.Distance(this.transform.position, collision.transform.position) <= enemy.rangeAttack)
            {
                this.GetComponent<EnemyAttack>().enabled = true;
                this.enabled = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            this.GetComponent<EnemyPatrol>().enabled = true;
            this.enabled = false;
        }
    }
}
