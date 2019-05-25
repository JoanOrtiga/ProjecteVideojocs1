using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[CreateAssetMenu(fileName = "PlayerModel", menuName = "Models/Characters/Player")]
public class PlayerModel : CharacterModel
{
    //PlayerController
    [Header("Player Controller")]
    [Range(0f, 20f)] public float speed = 4f;
    [Range(0f, 100f)] public float force = 70f;
    [Range(0f, 50f)] public float power = 20f;
    [Range(0f, 20f)] public float range = 10f;
    [Range(0, 10f)] public float TimeBetweenFlash = 3f;
    public float timeForFlash = 5f;

    //PlayerFlash
    [Header("Player Flash")]

    [Range(0f, 20f)] public float speedFlash = 10f;
    [Range(0f, 100f)] public float forceFlash = 100f;
    public float flashTime = 0.5f;

    //PlayerShoot
    [Header("Player Shoot")]

    public GameObject ArrowPrefab;

    public float shootVelocity = 15f;
    public float maximumAmunition = 5f;
    public float timeToRecharge = 1f;

    //CrossHair
    [Header("CrossHair")]

    public GameObject crossHair;
}
