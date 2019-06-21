using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SatanMov
{
    Loop, SatanasFreeMov, SatanasPlatformMov, SatanasFollowPlayerMov
}

public class SatanasMovementController : SatanasState {

    public int changeMovPossibilityPercentatge = 50;

	// Use this for initialization
	void Start () {
        GetComponent<SatanasFreeMov>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}

    protected SatanMov switchMov()
    {
        if(Random.Range(0, 100) < changeMovPossibilityPercentatge)
        {
            print("xox");
            return (SatanMov)Random.Range(1, 3);
        }

        print("sad");
        return SatanMov.Loop;
    }
}
