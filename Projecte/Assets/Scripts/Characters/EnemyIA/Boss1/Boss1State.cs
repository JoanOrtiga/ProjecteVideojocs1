﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Boss1State : CharacterState
{
    protected Transform p1, p2, p3;
    protected Rigidbody2D rb2d;
    protected Boss1Model boss;

    [HideInInspector] public bool attacking = false;

    private void Awake()
    {
        boss = GameManager.instance.boss1_model;
        rb2d = GetComponent<Rigidbody2D>();

        base.health = boss.health;
        base.initialHealth = boss.health;
    }

    void Start()
    {
        GetComponent<MovingState_Boss1>().enabled = true;
    }
}
