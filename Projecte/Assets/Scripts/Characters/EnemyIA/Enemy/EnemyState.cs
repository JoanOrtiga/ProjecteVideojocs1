using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyStates
{
    patrol, chase, attack
}

public class EnemyState : CharacterState
{
    protected EnemyModel enemy;

    protected Rigidbody2D rb2D;

    protected Animator atorSke;

    protected PlayerStates currentState;

    protected Collider2D patrolArea;

    override public void InitState()
    {
        base.health = enemy.health;

        rb2D = GetComponent<Rigidbody2D>();
        rb2D.isKinematic = true;

        atorSke = GetComponent<Animator>();
        patrolArea = GetComponent<Collider2D>();

        patrolArea.isTrigger = true;
    }
}
