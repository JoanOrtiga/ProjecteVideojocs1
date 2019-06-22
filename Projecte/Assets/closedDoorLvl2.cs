using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closedDoorLvl2 : Boss1State {

    private bool bossAlive;

    // Update is called once per frame
    void Update ()
    {
        if (GameObject.Find("Boss1") != null)
        {
            bossAlive = true;
        }

        if (bossAlive == true)
        {
            if (GameObject.Find("Boss1") == null)
            {
                GetComponent<SpriteRenderer>().enabled = false;
                transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }
}
