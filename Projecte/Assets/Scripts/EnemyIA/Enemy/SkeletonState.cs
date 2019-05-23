using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyStates
{
    attack, walk, idle
}

public class SkeletonState : CharacterState
{
    protected SkeletonModel skeleton;

    protected Rigidbody2D rb2D;

    protected Animator atorSke;

    protected PlayerStates currentState;

    protected Collider2D patrolArea;

    override public void InitState()
    {
        skeleton = GameManager.instance.skeletonModel;

        rb2D = GetComponent<Rigidbody2D>();
        rb2D.isKinematic = true;

        atorSke = GetComponent<Animator>();
        patrolArea = GetComponent<Collider2D>();

        patrolArea.isTrigger = true;
    }
}
