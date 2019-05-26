using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Boss1State))]
[RequireComponent(typeof(MovingState_Boss1))]
public class Attack1State_Boss1 : AttackingState
{

    public GameObject spikes;
    private float time1 = 0.05f;
    private float time2 = 3f;

    public float radius;
    public Vector2 center;


    private void OnEnable()
    {
        StartCoroutine(attack1());
    }
    
    IEnumerator attack1()
    {
        yield return new WaitForSeconds(time1);
        Instantiate(spikes, Random.insideUnitCircle * radius + center, transform.rotation);
        Instantiate(spikes, Random.insideUnitCircle * radius + center, transform.rotation);
        yield return new WaitForSeconds(time1);
        Instantiate(spikes, Random.insideUnitCircle * radius + center, transform.rotation);
        Instantiate(spikes, Random.insideUnitCircle * radius + center, transform.rotation);
        yield return new WaitForSeconds(time1);
        Instantiate(spikes, Random.insideUnitCircle * radius + center, transform.rotation);
        Instantiate(spikes, Random.insideUnitCircle * radius + center, transform.rotation);
        yield return new WaitForSeconds(time1);
        Instantiate(spikes, Random.insideUnitCircle * radius + center, transform.rotation);
        Instantiate(spikes, Random.insideUnitCircle * radius + center, transform.rotation);
        yield return new WaitForSeconds(time1);
        Instantiate(spikes, Random.insideUnitCircle * radius + center, transform.rotation);
        Instantiate(spikes, Random.insideUnitCircle * radius + center, transform.rotation);

        yield return new WaitForSeconds(time2);

        GetComponent<AttackingState>().attacking = false;
        GetComponent<Attack1State_Boss1>().enabled = false;
    }
}
