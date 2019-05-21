using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ChaseState))]

public class PatrolState : EnemyState
{
    public float patrolSpeed = 0.5f;

    private Vector2 patrolPoint;

    private void OnEnable()
    {
        SelectPatrolPoint();
    }

    private void SelectPatrolPoint()
    {
        float angle = Random.Range(0, 360);
        Vector2 newDir = Quaternion.AngleAxis(angle, Vector3.forward) * (-transform.up);

        int myLayer = gameObject.layer; //número de capa de este objeto (enemigo)
        int maskMyLayer = 1 << myLayer; //máscara de bit de la capa de este objeto
        int restOfLayers = ~maskMyLayer; //invierto todos los bits

        RaycastHit2D hit = Physics2D.Raycast(transform.position, newDir, perception.rangeVision, restOfLayers);
        if (hit.collider != null)
            patrolPoint = hit.point;
        else
            patrolPoint = (Vector2)transform.position + newDir * perception.rangeVision;

        transform.LookAt(transform.position + Vector3.forward, -newDir);
    }

    void FixedUpdate()
    {
        //logica para mover el enemigo en patrol
        //rb2D.transform.position += -transform.up * patrolSpeed * Time.deltaTime;

        rb2D.transform.position = Vector2.MoveTowards(rb2D.transform.position, patrolPoint, patrolSpeed * Time.deltaTime);
        if (((Vector2)rb2D.transform.position - patrolPoint).SqrMagnitude() < 0.3f)
        {
            SelectPatrolPoint();
        }
    }

    private void LateUpdate()
    {
        //logica para las transicion de este estado a otros
        if (perception.target != null)
        {
            GetComponent<ChaseState>().enabled = true;
            this.enabled = false;
        }
    }
}
