using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwampManState : CharacterState {

    protected SwampManModel swampManModel;
    protected Rigidbody2D rb2d;
    protected Animator anim;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    public override void InitState()
    {
        swampManModel = GameManager.instance.swampManModel;
        base.health = swampManModel.health;
        base.initialHealth = swampManModel.health;

     //   GetComponent<SkeletonPatrol>().enabled = true;
    }

    protected void changeAnim(Vector2 objectiveVector)
    {
        Vector2 direction = (objectiveVector - (Vector2)rb2d.transform.position).normalized;

        anim.SetFloat("moveX", direction.x);
        anim.SetFloat("moveY", direction.y);
    }

    private void FixedUpdate()
    {
        rb2d.velocity = Vector2.zero;
    }
}
