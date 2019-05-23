using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonPatrol : SkeletonState
{
    private Vector2 dirPoint;

    private void Start()
    {
        newPoint();
    }

    private void Update()
    {
        if(Vector2.Distance((Vector2)rb2D.transform.position,dirPoint) <= 0.5f)
        {
            atorSke.SetBool("Walking", false);
            newPoint();
        }
    }

    private void FixedUpdate()
    {
        rb2D.AddForce(dirPoint - (Vector2)rb2D.transform.position);
        rb2D.velocity = dirPoint - (Vector2)rb2D.transform.position;

    }

    private void newPoint()
    {
        dirPoint = Random.insideUnitCircle * 5f + (Vector2)rb2D.transform.position;
        print(dirPoint);
        //atorSke.SetBool("Walking", true);
    }
}
    