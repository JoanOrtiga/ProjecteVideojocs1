using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closedDoorLvl2 : Boss1State {

    // Update is called once per frame
    void Update ()
    {
        if (BossDead())
        {
            Destroy(gameObject);
        }
    }
}
