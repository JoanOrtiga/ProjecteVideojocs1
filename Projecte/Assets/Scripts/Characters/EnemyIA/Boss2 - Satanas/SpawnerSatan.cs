using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSatan : MonoBehaviour {

    public GameObject boss;
    public GameObject firePlatforms;
    public Vector2 position;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")  
        {
            Instantiate(firePlatforms, new Vector2(0, 0), collision.transform.rotation);
            Instantiate(boss, position, collision.transform.rotation); 
        }
    }
}
