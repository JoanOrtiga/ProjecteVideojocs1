using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonState : CharacterState {

    SkeletonModel skeletonModel;
    Rigidbody2D rb2d;

    private void Awake()
    {
        skeletonModel = GameManager.instance.skeletonModel;
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start ()
    {
        base.health = skeletonModel.health;
        base.initialHealth = skeletonModel.health;



	}
}
