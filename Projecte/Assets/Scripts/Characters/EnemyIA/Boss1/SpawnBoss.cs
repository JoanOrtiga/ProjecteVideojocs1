using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : MonoBehaviour
{

    public GameObject boss1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(boss1, new Vector2(-8.01f, 40.15f), collision.transform.rotation);
        Destroy(gameObject);
    }
}
