using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyModel", menuName = "Models/Characters/Enemy")]
public class EnemyModel : CharacterModel
{
    [Header("Drops")]
    public List<GameObject> drops;
    public List<int> randomDropPercentatges;

    [Header("Enemies")]
    public float chaseSpeed = 1f;
    public float rangeAttack = 0.5f;
    public float speed = 10f;
    public float damage = 20f;

}