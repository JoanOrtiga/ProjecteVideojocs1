using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closedDoorLvl2 : MonoBehaviour
{
    [SerializeField]
    private GameObject openedDoor;
    private bool bossAlive = false;

    // Update is called once per frame
    void Update ()
    {
        if (GameObject.Find("Boss1(Clone)") != null)
        {
            bossAlive = true;
        }

        if (bossAlive == true)
        {
            if (GameObject.Find("Boss1(Clone)") == null)
            {
                openedDoor.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
