using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LogModel", menuName = "Models/Characters/Enemy/Log")]
public class LogModel : EnemyModel
{
    [Header("Log")]
    public float timeBetweenDmg = 0.5f;
}
