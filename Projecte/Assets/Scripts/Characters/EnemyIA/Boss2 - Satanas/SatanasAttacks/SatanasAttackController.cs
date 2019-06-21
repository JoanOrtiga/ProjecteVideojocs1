using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatanasAttackController : SatanasState {

    

    private void Start()
    {
        newAtt();
    }

    protected void newAtt()
    {
        switch (whichMov())
        {
            case 0:
                GetComponent<SatanasFirePlatforms>().enabled = true;
                break;

            case 1:
                break;

            case 2:
                break;

            default:
                break;
        }
    }

    private int whichMov()
    {
        if (GetComponent<SatanasFreeMov>().enabled)
        {
            return 0;
        }
        else if (GetComponent<SatanasFollowPlayerMov>().enabled)
        {
            return 1;
        }
        else if (GetComponent<SatanasPlatformMov>().enabled)
        {
            return 2;
        }
        else return -1;
    }
}
