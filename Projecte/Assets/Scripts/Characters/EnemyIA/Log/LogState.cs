using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogState : CharacterState {

    protected LogModel logModel;
    protected Rigidbody2D rb2d;
    protected Animator anim;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    public override void InitState()
    {
        logModel = GameManager.instance.logModel;
        base.health = logModel.health;
        base.initialHealth = logModel.health;

        GetComponent<LogChase>().enabled = true;
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
