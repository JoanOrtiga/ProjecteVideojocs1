using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour {

    protected SpriteRenderer sprPlayer, sprShadow;
    protected Rigidbody2D rb2D;
    




    // Use this for initialization
    void Awake()
    {
        sprPlayer = GetComponent<SpriteRenderer>();
        sprShadow = transform.Find("Shadow").gameObject.GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
