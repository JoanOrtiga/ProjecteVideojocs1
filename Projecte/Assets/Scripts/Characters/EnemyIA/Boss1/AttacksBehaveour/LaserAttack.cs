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
                collision.GetComponent<PlayerState>().getDmg(GameManager.instance.boss1_model.attackLaserDmg);
            }
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.GetComponent<PlayerFlash>().flash != true)
            {
                collision.GetComponent<PlayerState>().getDmg(GameManager.instance.boss1_model.attackLaserDmg * Time.deltaTime);

            }
        }
    }
}
