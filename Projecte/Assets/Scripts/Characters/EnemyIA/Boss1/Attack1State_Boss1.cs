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
    public Vector3 center;


    private void OnEnable()
    {
        StartCoroutine(attack1());
    }

    IEnumerator attack1()
    {
        yield return new WaitForSeconds(time1);
        Instantiate(spikes, new Vector2(Random.Range(center.x - radius / 2, center.x + radius / 2), Random.Range(center.y - radius / 2, center.y + radius / 2)), transform.rotation);
        Instantiate(spikes, new Vector2(Random.Range(center.x - radius / 2, center.x + radius / 2), Random.Range(center.y - radius / 2, center.y + radius / 2)), transform.rotation);
        yield return new WaitForSeconds(time1);
        Instantiate(spikes, new Vector2(Random.Range(center.x - radius / 2, center.x + radius / 2), Random.Range(center.y - radius / 2, center.y + radius / 2)), transform.rotation);
        Instantiate(spikes, new Vector2(Random.Range(center.x - radius / 2, center.x + radius / 2), Random.Range(center.y - radius / 2, center.y + radius / 2)), transform.rotation);
        yield return new WaitForSeconds(time1);
        Instantiate(spikes, new Vector2(Random.Range(center.x - radius / 2, center.x + radius / 2), Random.Range(center.y - radius / 2, center.y + radius / 2)), transform.rotation);
        Instantiate(spikes, new Vector2(Random.Range(center.x - radius / 2, center.x + radius / 2), Random.Range(center.y - radius / 2, center.y + radius / 2)), transform.rotation);
        yield return new WaitForSeconds(time1);
        Instantiate(spikes, new Vector2(Random.Range(center.x - radius / 2, center.x + radius / 2), Random.Range(center.y - radius / 2, center.y + radius / 2)), transform.rotation);
        Instantiate(spikes, new Vector2(Random.Range(center.x - radius / 2, center.x + radius / 2), Random.Range(center.y - radius / 2, center.y + radius / 2)), transform.rotation);
        yield return new WaitForSeconds(time1);
        Instantiate(spikes, new Vector2(Random.Range(center.x - radius / 2, center.x + radius / 2), Random.Range(center.y - radius / 2, center.y + radius / 2)), transform.rotation);
        Instantiate(spikes, new Vector2(Random.Range(center.x - radius / 2, center.x + radius / 2), Random.Range(center.y - radius / 2, center.y + radius / 2)), transform.rotation);

        yield return new WaitForSeconds(time2);

        GetComponent<AttackingState>().attacking = false;
        GetComponent<Attack1State_Boss1>().enabled = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(100, 100, 100);
        Gizmos.DrawSphere(center, radius);
    }
}
