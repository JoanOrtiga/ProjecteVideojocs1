using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PatrolState))]
public class ChaseState : EnemyState
{

    public float chaseSpeed = 1f;
    public float attackDistance = 0.5f;

    private float sqrAttackDistance;
    // Use this for initialization
    void Start()
    {
        sqrAttackDistance = attackDistance * attackDistance;
    }


    private void FixedUpdate()
    {
        if (perception.target == null)
            return;

        Vector2 toPlayer = (Vector2)(perception.target.position - transform.position);
        rb2D.transform.LookAt(transform.position + Vector3.forward, -toPlayer);
        rb2D.transform.position += -transform.up * chaseSpeed * Time.deltaTime;
    }

    private void LateUpdate()
    {
        if (perception.target == null)
        {
            GetComponent<PatrolState>().enabled = true;
            this.enabled = false;
            return;
        }
        float dist = ((Vector2)(perception.target.position - transform.position)).sqrMagnitude;

        if (dist <= sqrAttackDistance)
        {
            GetComponent<AttackState>().enabled = true;
            this.enabled = false;
            return;
        }
    }
}
