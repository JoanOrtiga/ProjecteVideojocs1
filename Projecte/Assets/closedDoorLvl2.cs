using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closedDoorLvl2 : MonoBehaviour
{
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
            if (GameObject.Find("Boss1") == false)
            {
                GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("OpenedDoor").SetActive(true);
            }
        }
    }
}
