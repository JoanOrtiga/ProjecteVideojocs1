using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SwampMan", menuName = "Models/Characters/Enemy/SwampMan")]
public class SwampManModel : EnemyModel
{
    [Header("SwampMan")]
    public GameObject ball;

    public float attackBallMud = 20f;
    public float ballSpeed = 2;
    public float timeBetweenAttacks = 0.4f;
    public float CoolDown = 3f;
    public float timeToDestroy = 2.0f;
}
