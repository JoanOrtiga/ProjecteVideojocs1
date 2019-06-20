using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicInAltar : MonoBehaviour
{

    public enum RelicToDetect
    {
        bible, grail, cross
    }

    public RelicToDetect relic;

    public GameObject relicToSpawn;

    [HideInInspector] public bool relicPlaced = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            switch (relic)
            {
                case RelicToDetect.bible:
                    if (Input.GetButton("ActionKey") && collision.GetComponent<PlayPickupRelicInvetory>().relic_bible)
                        spawnRelic();
                    break;
                case RelicToDetect.grail:
                    if (Input.GetButton("ActionKey") && collision.GetComponent<PlayPickupRelicInvetory>().relic_grail)
                        spawnRelic();
                    break;
                case RelicToDetect.cross:
                    if (Input.GetButton("ActionKey") && collision.GetComponent<PlayPickupRelicInvetory>().relic_cross)
                        spawnRelic();
                    break;
            }
        }
    }

    private void spawnRelic()
    {
       GameObject relic =  Instantiate(relicToSpawn, (Vector2)transform.position + new Vector2(-0.10f, 0.40f), transform.rotation);
        relic.transform.parent = this.transform.parent;


        relicPlaced = true;
        gameObject.SetActive(false);
    }
}
