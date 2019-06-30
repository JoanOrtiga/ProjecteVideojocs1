using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatanasAttackController : SatanasState {

    

    private void Awake()
    {
        newAtt();
    }

    protected void newAtt()
    {
        deActivate();
        switch (whichMov())
        {
            case 0:
              //  GetComponent<SatanasFirePlatforms>().enabled = true;
                 GetComponent<SatanasFireBallAttack>().enabled = true;
                break;

            case 1:
                GetComponent<SatanasFirePlatforms>().enabled = true;
                break;

            case 2:
                GetComponent<SatanCrossAttack>().enabled = true;
                break;

            default:
                break;
        }
    }

    private void Update()
    {
        if(!GetComponent<SatanasFirePlatforms>().enabled && !GetComponent<SatanasFireBallAttack>().enabled && !GetComponent<SatanCrossAttack>().enabled)
        {
            newAtt();
        }
    }

    private void deActivate()
    {
        GetComponent<SatanasFirePlatforms>().enabled = false;
        GetComponent<SatanasFireBallAttack>().enabled = false;
        GetComponent<SatanCrossAttack>().enabled = false;
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
