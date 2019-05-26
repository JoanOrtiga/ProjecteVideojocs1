using UnityEngine;
using System.Collections;

public class Attack2State_Boss1 : AttackingState
{
    public GameObject fireBall;



    // Use this for initialization
    private void OnEnable()
    {
        StartCoroutine(attack2());
    }

    IEnumerator attack2()
    {
        yield return new WaitForSeconds(boss.timeBetweenFireBall);
        Instantiate(fireBall, rb2d.transform.position, transform.rotation);
        yield return new WaitForSeconds(boss.timeBetweenFireBall);
        Instantiate(fireBall, rb2d.transform.position, transform.rotation);
        yield return new WaitForSeconds(boss.timeBetweenFireBall);
        Instantiate(fireBall, rb2d.transform.position, transform.rotation);
        yield return new WaitForSeconds(boss.timeBetweenFireBall);
        Instantiate(fireBall, rb2d.transform.position, transform.rotation);
        yield return new WaitForSeconds(boss.timeBetweenFireBall);
        Instantiate(fireBall, rb2d.transform.position, transform.rotation);
        
        yield return new WaitForSeconds(boss.CooldownFireball);

        GetComponent<AttackingState>().attacking = false;
        GetComponent<Attack2State_Boss1>().enabled = false;
    }
}
