using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closedDoorLvl2 : MonoBehaviour
{
    public GameObject openedDoor;
    private bool bossAlive = false;

    // Update is called once per frame
    void Update ()
    {
        Debug.Log("Exists" + bossAlive);
        if (GameObject.Find("Boss1(Clone)") != null)
        {
            bossAlive = true;
        }

        if (bossAlive == true)
        {
            if (GameObject.Find("Boss1(Clone)") == null)
            {
                Debug.Log("Dead boss");
                openedDoor.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
