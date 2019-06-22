using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatanasFollowPlayerMov : SatanasMovementController {

    Transform playerPos;
    Transform coll;

    private float maxTimeCd;

	// Use this for initialization
	void Start () {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().transform;
    }

    private void OnEnable()
    {
        maxTimeCd = satanModel.maxTimeFollowPlayer;
    }

    private void FixedUpdate()
    {
        if(((Vector2)playerPos.position - (Vector2)rb2d.transform.position).SqrMagnitude() >= 50f && maxTimeCd > 0)
            rb2d.transform.position = Vector2.MoveTowards(rb2d.transform.position, playerPos.position, satanModel.followPlayerSpeed * Time.deltaTime);
        else
            changeMov();

        maxTimeCd -= Time.fixedDeltaTime;
    }

    protected override void changeMov()
    {
        switch (base.switchMov())
        {
            case SatanMov.SatanasPlatformMov:
                GetComponent<SatanasPlatformMov>().enabled = true;
                this.enabled = false;
                break;
            case SatanMov.SatanasFreeMov:
                GetComponent<SatanasFreeMov>().enabled = true;
                this.enabled = false;
                break;
        }
    }
}
