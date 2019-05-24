using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterState : MonoBehaviour
{
    public bool IsDefaultState = false;

    public float health { get; set; }

    virtual public void InitState()
    {

    }

    public void recieveDmg(float damage)
    {
        health -= damage;
        print("BOSS: " + health);
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }
}
