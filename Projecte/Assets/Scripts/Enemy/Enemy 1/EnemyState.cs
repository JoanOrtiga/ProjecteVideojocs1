using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Perception))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class EnemyState : MonoBehaviour
{
    protected Perception perception;
    protected Rigidbody2D rb2D;
    protected Animator ator;

    private void Awake()
    {
        perception = GetComponent<Perception>();
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.isKinematic = true;

        ator = GetComponent<Animator>();
    }

}