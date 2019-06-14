using UnityEngine;
using System.Collections;

public class Attack3State_Boss1 : AttackingState
{
    // Use this for initialization
    private void OnEnable()
    {
        StartCoroutine(attack3());
    }

    IEnumerator attack3()
    {
        GetComponentInChildren<LaserAttack>().enabled = true;
        GetComponentsInChildren<SpriteRenderer>()[1].enabled = true;
        GetComponentsInChildren<Collider2D>()[1].enabled = true;
        
        yield return new WaitForSeconds(boss.laserTime);


        GetComponentInChildren<LaserAttack>().enabled = false;
        GetComponentsInChildren<SpriteRenderer>()[1].enabled = false;
        GetComponentsInChildren<Collider2D>()[1].enabled = false;

        yield return new WaitForSeconds(boss.CooldownLaser);

        GetComponent<AttackingState>().attacking = false;
        GetComponent<Attack3State_Boss1>().enabled = false;
    }
}
