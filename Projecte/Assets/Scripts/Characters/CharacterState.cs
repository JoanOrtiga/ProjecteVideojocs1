using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterState : MonoBehaviour
{
    public bool IsDefaultState = false;

    protected float health;

    protected float initialHealth;

    virtual public void InitState()
    {

    }

    public void recieveDmg(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }

        GetComponentsInChildren<Image>()[1].fillAmount = health / initialHealth;
    }
}
