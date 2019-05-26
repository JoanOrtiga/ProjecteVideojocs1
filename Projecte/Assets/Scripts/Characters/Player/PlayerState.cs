using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerStates
{
    attack, walk, idle, flash
}

public class PlayerState : CharacterState {

    protected SpriteRenderer sprPlayer, sprShadow;
    protected Rigidbody2D rb2D;
    protected Animator animator;

    protected float featherPower;

    protected float h, v;

    protected PlayerStates currentState;

    protected PlayerModel playerModel;

    public override void InitState()
    {
        playerModel = GameManager.instance.playerModel;
        rb2D = GetComponent<Rigidbody2D>();
        sprPlayer = GetComponent<SpriteRenderer>();
        sprShadow = transform.Find("Shadow").gameObject.GetComponent<SpriteRenderer>();

        animator = GetComponent<Animator>();
    }
}
