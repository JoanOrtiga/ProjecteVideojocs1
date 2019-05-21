using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : EnemyState
{

    private void OnEnable()
    {
        ator.SetTrigger("attack");
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {

    }
}

