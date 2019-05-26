using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : MonoBehaviour
{

    public GameObject boss1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.GetComponent<PlayPickupRelicInvetory>().relic0 == true &&
                        collision.GetComponent<PlayPickupRelicInvetory>().relic1 == true &&
                        collision.GetComponent<PlayPickupRelicInvetory>().relic2 == true)
            {
                Instantiate(boss1, new Vector2(-8.01f, 40.15f), collision.transform.rotation);
                Destroy(gameObject);
            }
        }
        
    }
        
}
