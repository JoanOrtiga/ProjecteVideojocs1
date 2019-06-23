using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Boss1", menuName = "Models/Characters/Boss")]
public class Boss1Model : EnemyModel
{
    public float speedInterpolation = 0.04f;

    [Header("FireBallAttack")]
    public float attackFireBallDmg;
    public float ballSpeed;
    public float timeBetweenFireBall = 0.4f;
    public float CooldownFireball = 3f;

    [Header("SpikesAttack")]
    public float attackSpikesDmg;
    public float timeBetweenSpikes = 0.05f;
    public float Cooldown = 3f;
    public float radius;
    public Vector2 center;
    public float timeToDestroy = 2.2f;

    [Header("LaserAttack")]
    public float attackLaserDmg;
    public float laserTime = 3f;
    public float CooldownLaser = 3f;

    

}
