using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesDMG : MonoBehaviour
{
    public float DMG = 50f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            collision.GetComponent<PlayerState>().getDmg(DMG);
            
        }

    }

}
