using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private GameObject[] _enemies;
    PlayerModel _player;

    // Use this for initialization
    void Start()
    {
        _player = GameManager.instance.playerModel;
    }

    // Update is called once per frame
    void Update()
    {
        _enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }

    private void Attack()
    {
        foreach (GameObject enemy in _enemies)
        {
            if (Vector3.Distance(this.transform.position, enemy.transform.position) <= _player.range)
            {
                enemy.GetComponent<EnemyScript>().SetHealth(-_player.power);
            }
        }
        return;
    }
}