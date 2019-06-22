using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Boss1State : CharacterState
{
    protected Transform p1, p2, p3;
    protected Rigidbody2D rb2d;
    protected Boss1Model boss;

    [HideInInspector] public bool attacking = false;

    private GameObject bossWalls;

    private void Awake()
    {
        boss = GameManager.instance.boss1_model;
        rb2d = GetComponent<Rigidbody2D>();

        base.health = boss.health;
        base.initialHealth = boss.health;
    }

    void Start()
    {
        GetComponent<MovingState_Boss1>().enabled = true;
        bossWalls = GameObject.Find("bossWalls").gameObject;
    }

    private void OnDestroy()
    {
        if(bossWalls != null)
        {
            foreach (Transform child in bossWalls.transform)
            {
                Destroy(child.gameObject);
            }

            foreach (GameObject item in GameObject.FindGameObjectsWithTag("BossComponents"))
            {
                Destroy(item);
            }

            Destroy(bossWalls);
        }       
    }
}
