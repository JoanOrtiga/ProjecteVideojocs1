using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SatanModel", menuName = "Models/Characters/SatanModel")]
public class SatanModel : EnemyModel {
    [Header("SatanMov")]
    public float changeMovPercentatge = 50f;
    public float followPlayerSpeed = 2f;
    public float maxTimeFollowPlayer = 5f;

    [Header("ATTACKS")]
    public float coolDownBetweenAttacks = 2f;

    [Header("SatanFire")]
    public float chanceOf2Platforms = 50f;
    public float timeOfLive = 4f;
    public float marginTime = 1.5f;
    public float lavaDamage = 30f;

    [Header("SatanFireBall")]
    public float timeBetweenFireBall = 0.4f;
    public float timeToDestroy;
    public float fireBallDmg;
    public float fireBallSpeed;
}
