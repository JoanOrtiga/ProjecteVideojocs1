using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : EnemyState
{
    private Vector2 dirPoint;

    private void OnEnable()
    {
    //    atorSke.SetTrigger("SkeletonAttack");
    }

    private void Update()
    {
        if (Vector2.Distance(this.transform.position, dirPoint)>enemy.rangeAttack)
        {
            this.GetComponent<EnemyChase>().enabled = true;
            this.enabled = false;
        }
    }
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Change PlayerModel For the script that manages player life
            collision.GetComponent<PlayerModel>().health = -enemy.damage;
        }
    }


}
