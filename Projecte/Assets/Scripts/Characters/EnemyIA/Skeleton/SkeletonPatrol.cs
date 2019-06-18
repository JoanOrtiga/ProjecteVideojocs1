using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonPatrol : SkeletonState
{
    private Vector2 randomPoint;
    private float radius;

    // Use this for initialization
    void Start()
    {
        radius = GetComponent<CircleCollider2D>().radius;
        SelectPatrolPoint();

        anim.SetBool("walking", true);
    }

    private void FixedUpdate()
    {
        if(skeletonModel != null)
            rb2d.transform.position = Vector2.MoveTowards(rb2d.transform.position, randomPoint, skeletonModel.speed * Time.deltaTime);

        if (((Vector2)rb2d.transform.position - randomPoint).SqrMagnitude() < 0.3f)
        {
            SelectPatrolPoint();
        }

        base.changeAnim(randomPoint);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        SelectPatrolPoint();
    }

    private void SelectPatrolPoint()
    {
        randomPoint = (Vector2)rb2d.transform.position + Random.insideUnitCircle * radius;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GetComponent<SkeletonChase>().enabled = true;
            this.enabled = false;
        }
    }

    
}
