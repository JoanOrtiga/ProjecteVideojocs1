using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBoss : MonoBehaviour
{

    public GameObject boss1;
    public Image PressF;
    public Vector2 spawnPlace;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.GetComponent<PlayPickupRelicInvetory>().relic0 == true && collision.GetComponent<PlayPickupRelicInvetory>().relic1 == true && collision.GetComponent<PlayPickupRelicInvetory>().relic2 == true){

                PressF.enabled = true;

                if (Input.GetButton("ActionKey"))
                {
                    Instantiate(boss1, spawnPlace, collision.transform.rotation);
                    Destroy(gameObject);
                }
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PressF.enabled = false;
    }

}
