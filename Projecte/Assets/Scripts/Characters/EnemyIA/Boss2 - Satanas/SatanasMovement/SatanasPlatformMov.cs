using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatanasPlatformMov : SatanasMovementController {

    private int platformToGo;
    private Transform[] platforms = new Transform[4];

    // Use this for initialization
    void Start () {
        platforms = GameObject.FindGameObjectWithTag("BossComponents").transform.GetComponentsInChildren<Transform>();
    }

    private void OnEnable()
    {
        newPlatform();
    }

    private void FixedUpdate()
    {
        rb2d.transform.position = Vector2.MoveTowards(rb2d.transform.position, platforms[platformToGo].position, satanModel.speed * Time.deltaTime);

        if(((Vector2)platforms[platformToGo].position - (Vector2)rb2d.transform.position).SqrMagnitude() <= 2f)
        {
            newPlatform();
            changeMov();
        }
    }

    private void newPlatform()
    {
        platformToGo = Random.Range(1, 4);
    }

    protected override void changeMov()
    {
        switch (base.switchMov())
        {
            case SatanMov.SatanasFollowPlayerMov:
                GetComponent<SatanasFollowPlayerMov>().enabled = true;
                this.enabled = false;
                break;
            case SatanMov.SatanasFreeMov:
                GetComponent<SatanasFreeMov>().enabled = true;
                this.enabled = false;
                break;
        }
    }
}
