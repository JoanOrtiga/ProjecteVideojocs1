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

        GetComponent<SwampManController>().enabled = true;
    }

    protected void changeAnim(Vector2 objectiveVector)
    {
        print(objectiveVector.x + "  " + objectiveVector.y);

        anim.SetFloat("moveX", objectiveVector.x);
        anim.SetFloat("moveY", objectiveVector.y);
    }
}
