using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{

    public GameObject Enemy;
    private float timeOfSpawn = 0f;
    private bool spawnerIniciated = false;
    public int maxNumberOfEnemy = 4;
    private int numebrOfEnemiesMade;

    private void Start()
    {
        timeOfSpawn = 3;
    }

    private void Update()
    {
        timeOfSpawn = timeOfSpawn + Time.deltaTime;

        if (timeOfSpawn >= 3 && spawnerIniciated && numebrOfEnemiesMade < maxNumberOfEnemy)
        {
            timeOfSpawn = 0;
            Instantiate(Enemy, new Vector2(this.transform.position.x, this.transform.position.y), this.transform.rotation);
            numebrOfEnemiesMade++;
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        spawnerIniciated = true;
        
    }

}
