using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "KnightModel", menuName = "Models/Characters/Enemy/KnightModel")]
public class KnightModel : EnemyModel {

    [Header("Knight")]
    public float timeBetweenDamage = 0.5f;
    public float rangeVision = 4f;
}
