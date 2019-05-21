using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerModel", menuName = "Models")]
public class PlayerModel : CharacterModel
{
    public float normalSpeed = 1f;

    public float normalForce = 5f;

    /*public float flashSpeed = 10f;
    public float flashForce = 100f;
    public float flashTime = 10f;
    public LayerMask flasHiddenLayer;*/
}
