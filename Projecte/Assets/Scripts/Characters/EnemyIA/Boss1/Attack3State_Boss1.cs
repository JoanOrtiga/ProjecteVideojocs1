using UnityEngine;
using System.Collections;

public class Attack3State_Boss1 : AttackingState
{
    private float time1 = 3f;
    private float time2 = 3f;

    // Use this for initialization
    private void OnEnable()
    {
        StartCoroutine(attack3());
    }

    IEnumerator attack3()
    {
        GetComponentInChildren<LaserAttack>().enabled = true;
        GetComponentsInChildren<SpriteRenderer>()[1].enabled = true;
        GetComponentsInChildren<Collider2D>()[0].enabled = true;
        
        yield return new WaitForSeconds(time1);


        GetComponentInChildren<LaserAttack>().enabled = false;
        GetComponentsInChildren<SpriteRenderer>()[1].enabled = false;
        GetComponentsInChildren<Collider2D>()[0].enabled = false;

        yield return new WaitForSeconds(time2);

        GetComponent<AttackingState>().attacking = false;
        GetComponent<Attack3State_Boss1>().enabled = false;
    }
}
