using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerStates
{
    attack, walk, idle, flash
}

public class PlayerState : MonoBehaviour {

    protected SpriteRenderer sprPlayer, sprShadow;
    protected Rigidbody2D rb2D;
    protected Animator animator;

    protected float h, v;

    protected PlayerStates currentState;

    protected PlayerModel playerModel;

    // Use this for initialization
    void Awake()
    {
        playerModel = GameManager.instance.playerModel;

        sprPlayer = GetComponent<SpriteRenderer>();
        sprShadow = transform.Find("Shadow").gameObject.GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
}
