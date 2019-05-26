using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBoss : MonoBehaviour
{

    public GameObject boss1;
    public Image PressF;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            if (collision.GetComponent<PlayPickupRelicInvetory>().relic0 == true
                       && collision.GetComponent<PlayPickupRelicInvetory>().relic1 == true
                       && collision.GetComponent<PlayPickupRelicInvetory>().relic2 == true)
            {
                PressF.enabled = true;
                if (Input.GetKeyDown(KeyCode.Space))

                {
                    Debug.Log("SUMOONS");
                    Instantiate(boss1, new Vector2(-8.01f, 40.15f), collision.transform.rotation);
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
