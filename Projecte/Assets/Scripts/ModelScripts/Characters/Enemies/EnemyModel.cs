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
    public float patrolSpeed = 0.5f;
    public float timeToPerception = 0.2f;
    public float chaseSpeed = 1f;

    public float range = 0.5f;

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

    public GameObject _skeletonProjectile;

    public GameObject _swampProjectile;

    public GameObject _magicianProjectile;

    public EnemyType _enemyType;

    public GameObject[] _enemies;
}
