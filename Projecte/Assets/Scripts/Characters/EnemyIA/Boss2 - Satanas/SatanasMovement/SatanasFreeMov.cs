using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SatanasFreeMov : SatanasMovementController
{
    public float lengthVector = 5f;
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
        if(objective != null) 
            rb2d.transform.position = Vector2.Lerp(rb2d.transform.position, objective, satanModel.speed * Time.deltaTime);

        if ((objective - (Vector2)rb2d.transform.position).SqrMagnitude() < 0.5f)
        {
            objective = findObjective();

            changeMov();
        }
    }

    private void changeMov()
    {
        switch (base.switchMov())
        {
            case SatanMov.SatanasPlatformMov:
                GetComponent<SatanasPlatformMov>().enabled = true;
                this.enabled = false;
                break;
            case SatanMov.SatanasFollowPlayerMov:
                GetComponent<SatanasFollowPlayerMov>().enabled = true;
                this.enabled = false;
                break;
        }
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        objective = findObjective();

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        objective = findObjective();
    }


    public Vector2 findObjective()
    {
        return (Vector2)rb2d.transform.position + (new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)) * lengthVector);

    }




}
