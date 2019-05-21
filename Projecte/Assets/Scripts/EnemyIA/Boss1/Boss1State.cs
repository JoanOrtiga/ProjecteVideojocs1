using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Boss1State : MonoBehaviour {

    protected Transform p1, p2, p3;

    protected Rigidbody2D rb2d;
    protected Boss1Model boss;

    protected bool attacking = false;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.isKinematic = true;
    }

    // Use this for initialization
    void Start()
    {
        p1 = transform.Find("Range1");
        p2 = transform.Find("Range2");
        p3 = transform.Find("Range3");

        if (boss == null && GameManager.instance.boss1_model != null)
            boss = GameManager.instance.boss1_model;

        GetComponent<MovingState_Boss1>().enabled = true;
    }

    private void Update()
    {
        p1.parent = null;
        p2.parent = null;
        p3.parent = null;
    }
}
