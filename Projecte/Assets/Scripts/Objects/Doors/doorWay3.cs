using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorWay3 : MonoBehaviour {

    private Vector2 playerPosition;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.GetComponent<PlayPickupRelicInvetory>().relic_bible && collision.GetComponent<PlayPickupRelicInvetory>().relic_cross)
            {
                Destroy(transform.parent.gameObject);
            }
        }
    }
}
