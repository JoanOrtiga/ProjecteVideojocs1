using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorWay2 : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayPickupRelicInvetory>().relic_cross)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
