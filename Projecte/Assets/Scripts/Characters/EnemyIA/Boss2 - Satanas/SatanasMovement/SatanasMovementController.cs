using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SatanMov
{
    Loop, SatanasFreeMov, SatanasPlatformMov, SatanasFollowPlayerMov
}

public class SatanasMovementController : SatanasState
{

    // Use this for initialization
    void Start()
    {
        GetComponent<SatanasFreeMov>().enabled = true;
    }

    protected SatanMov switchMov()
    {
        if (Random.Range(0, 100) < satanModel.changeMovPercentatge)
        {
            return (SatanMov)Random.Range(1, 4);
        }

        return SatanMov.Loop;
    }

    protected virtual void changeMov()
    {

    }


}
