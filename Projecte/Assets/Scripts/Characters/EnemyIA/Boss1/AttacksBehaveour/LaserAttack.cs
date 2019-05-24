using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LaserAttack : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.GetComponent<PlayerFlash>().flash != true)
            {
                //dmgPlyr;
                print("DMG");
            }
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.GetComponent<PlayerFlash>().flash != true)
            {
                print("DM");
                //dmgPlyr;
            }
        }
    }
}
