﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightState : CharacterState {

    protected KnightModel knightModel;
    protected Rigidbody2D rb2d;
    protected Animator anim;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    public override void InitState()
    {
        knightModel = GameManager.instance.knightModel;
        base.health = knightModel.health;
        base.initialHealth = knightModel.health;

        GetComponent<KnightChase>().enabled = true;
    }

    private void Update()
    {

        print(base.health);
    }

    protected void changeAnim(Vector2 objectiveVector)
    {
        Vector2 direction = (objectiveVector - (Vector2)rb2d.transform.position).normalized;

        anim.SetFloat("moveX", direction.x);
        anim.SetFloat("moveY", direction.y);
    }
}
