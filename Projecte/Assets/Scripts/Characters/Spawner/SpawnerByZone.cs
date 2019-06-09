using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerByZone : MonoBehaviour {

    Collider2D spawnCollider;

    public GameObject enemyToSpawn;

    //Use this for initialization
    public float maxTime = 5f;
    public float minTime = 2f;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    void Start()
    {
        spawnCollider = GetComponent<Collider2D>();
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;

        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }

    }

    void SpawnObject()
    {
        time = minTime;
        Instantiate(enemyToSpawn, new Vector2(Random.Range(spawnCollider.bounds.min.x, spawnCollider.bounds.max.x), Random.Range(spawnCollider.bounds.min.y, spawnCollider.bounds.max.y)), transform.rotation);
    }
    
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }
}
