using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatanasState : CharacterState
{
    protected Transform p1, p2, p3;
    protected Rigidbody2D rb2d;
    protected SatanModel satanModel;

    protected SatanMov satanMov;

    public override void InitState()
    {
        satanModel = GameManager.instance.satanModel;
        rb2d = GetComponent<Rigidbody2D>();

        base.health = satanModel.health;
        base.initialHealth = satanModel.health;
    }

    private void Start()
    {
        GetComponent<SatanasMovementController>().enabled = true;
        GetComponent<SatanasAttackController>().enabled = true;
    }

}
