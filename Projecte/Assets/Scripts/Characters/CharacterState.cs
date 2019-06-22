using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterState : MonoBehaviour
{
    public bool IsDefaultState = false;

    protected float health;

    protected float initialHealth;

    protected List<GameObject> drops;
    protected List<int> dropChances;


    virtual public void InitState()
    {

    }

    public void recieveDmg(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Drops(gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation);

            if (base.tag == GameObject.FindWithTag("BossLvl1").tag)
            {
                BossDead();
            }

            Destroy(gameObject);
        }

        GetComponentsInChildren<Image>()[1].fillAmount = health / initialHealth;
    }

    private void Drops(Vector2 position, Quaternion rotation)
    {
        if (drops != null && dropChances != null)
        {
            int drop = Random.Range(0, drops.Count);
            int dropping = Random.Range(0, 100);

            if(dropping < dropChances[drop])
            {
                Instantiate(drops[drop], position, rotation);
            }

        }
    }

    public bool BossDead()
    {
        return true;
    }
}
