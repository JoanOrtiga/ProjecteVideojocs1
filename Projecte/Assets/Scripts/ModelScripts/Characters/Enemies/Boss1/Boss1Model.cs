using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Boss1", menuName = "Models/Characters/Boss")]
public class Boss1Model : CharacterModel
{
    public float speedInterpolation = 0.04f;

    public float attack1Dmg;
    public float attack2Dmg;
    public float attack3Dmg;
}
