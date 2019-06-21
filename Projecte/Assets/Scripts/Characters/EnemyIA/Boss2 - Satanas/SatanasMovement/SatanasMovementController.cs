using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SatanMov
{
    SatanasFreeMov, SatanasPlatformMov, SatanasFollowPlayerMov
}

public class SatanasMovementController : SatanasState {

	// Use this for initialization
	void Start () {
        GetComponent<SatanasFreeMov>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}
}
