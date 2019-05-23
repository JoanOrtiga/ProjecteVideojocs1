using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyModel", menuName = "Models/Characters/Enemy")]
public class EnemyModel : CharacterModel
{
    [Header("Perception")]
    [Range(0.5f, 10f)] public float rangeVision = 2f;
    [Range(0, 1)] public float FOV = 0.5f;
    [Header("EnemyState")]

    protected float patrolSpeed = 0.5f;

    protected float timeToPerception = 0.2f;

    [HideInInspector]public float chaseSpeed = 1f;

    protected float rangeAttack = 0.5f;

    public enum EnemyType
    {
        Trunk,
        Spider,
        Bat,
        Skeleton,
        Swamp,
        Vampire,
        Devil1,
        Devil2,
        Devil3,
        Warrior,
        Magician
    };

    public EnemyType _enemyType;
}
