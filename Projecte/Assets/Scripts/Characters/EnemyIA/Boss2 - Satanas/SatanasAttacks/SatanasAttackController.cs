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
        deActivate();
        switch (whichMov())
        {
            case 0:
                GetComponent<SatanasFireBallAttack>().enabled = true;
               //GetComponent<SatanasFirePlatforms>().enabled = true;
                break;

            case 1:
                GetComponent<SatanasFireBallAttack>().enabled = true;
             //   GetComponent<SatanasFirePlatforms>().enabled = true;
                break;

            case 2:
                GetComponent<SatanasFireBallAttack>().enabled = true;
                //GetComponent<SatanasFirePlatforms>().enabled = true;
                break;

            default:
                break;
        }


    }

    private void deActivate()
    {
        GetComponent<SatanasFirePlatforms>().enabled = false;
        GetComponent<SatanasFireBallAttack>().enabled = false;
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
