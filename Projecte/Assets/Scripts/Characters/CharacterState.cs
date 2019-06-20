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

    virtual public void InitState()
    {

    }

    public void recieveDmg(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Drops(gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation);
            Destroy(gameObject);
        }

        GetComponentsInChildren<Image>()[1].fillAmount = health / initialHealth;
    }

    private void Drops(Vector2 position, Quaternion rotation)
    {
        if(drops.Count > 0)
        {
       //     int drop = Random.Range(0f, drops.Count);

   

          //  Instantiate(drops[drop], position, rotation);
        }
        
    }
}
