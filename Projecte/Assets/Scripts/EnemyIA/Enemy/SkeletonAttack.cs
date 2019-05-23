using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAttack : SkeletonState
{
    private void OnEnable()
    {
    //    atorSke.SetTrigger("SkeletonAttack");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerModel>()._health = -skeleton._power;
        }
    }
}
