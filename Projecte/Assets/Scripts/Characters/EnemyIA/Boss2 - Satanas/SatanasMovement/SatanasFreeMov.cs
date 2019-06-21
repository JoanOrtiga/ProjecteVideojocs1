using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SatanasFreeMov : SatanasMovementController
{

    private Vector2 objective;

    private void Awake()
    {
        Random.InitState(System.Guid.NewGuid().GetHashCode());
    }

    private void OnEnable()
    {
        objective = findObjective();
    }

    private void FixedUpdate()
    {
        print(objective);

        if(objective != null) 
            rb2d.transform.position = Vector2.MoveTowards(rb2d.transform.position, objective, satanModel.speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("xd");
        objective = findObjective();

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        print("xd");
        objective = findObjective();
    }

    public Vector2 findObjective()
    {
        
        return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
    }




}
