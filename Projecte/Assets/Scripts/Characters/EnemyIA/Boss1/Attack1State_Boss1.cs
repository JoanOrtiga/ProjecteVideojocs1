using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Boss1State))]
[RequireComponent(typeof(MovingState_Boss1))]
public class Attack1State_Boss1 : AttackingState
{

    public GameObject spikes;

    private void OnEnable()
    {
        StartCoroutine(attack1());
    }
    
    IEnumerator attack1()
    {
        yield return new WaitForSeconds(boss.timeBetweenSpikes);
        Instantiate(spikes, Random.insideUnitCircle * boss.radius + boss.center, transform.rotation);
        Instantiate(spikes, Random.insideUnitCircle * boss.radius + boss.center, transform.rotation);
        yield return new WaitForSeconds(boss.timeBetweenSpikes);
        Instantiate(spikes, Random.insideUnitCircle * boss.radius + boss.center, transform.rotation);
        Instantiate(spikes, Random.insideUnitCircle * boss.radius + boss.center, transform.rotation);
        yield return new WaitForSeconds(boss.timeBetweenSpikes);
        Instantiate(spikes, Random.insideUnitCircle * boss.radius + boss.center, transform.rotation);
        Instantiate(spikes, Random.insideUnitCircle * boss.radius + boss.center, transform.rotation);
        yield return new WaitForSeconds(boss.timeBetweenSpikes);
        Instantiate(spikes, Random.insideUnitCircle * boss.radius + boss.center, transform.rotation);
        Instantiate(spikes, Random.insideUnitCircle * boss.radius + boss.center, transform.rotation);
        yield return new WaitForSeconds(boss.timeBetweenSpikes);
        Instantiate(spikes, Random.insideUnitCircle * boss.radius + boss.center, transform.rotation);
        Instantiate(spikes, Random.insideUnitCircle * boss.radius + boss.center, transform.rotation);
        yield return new WaitForSeconds(boss.timeBetweenSpikes);
        Instantiate(spikes, Random.insideUnitCircle * boss.radius + boss.center, transform.rotation);
        Instantiate(spikes, Random.insideUnitCircle * boss.radius + boss.center, transform.rotation);

        yield return new WaitForSeconds(5);
        
        GetComponent<AttackingState>().attacking = false;
        GetComponent<Attack1State_Boss1>().enabled = false;
    }
}
