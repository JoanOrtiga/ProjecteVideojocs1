using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ArrowController : MonoBehaviour
{

    public float speed = 4f;
    public GameObject explosion;
    public float DMG = 50;


    private Rigidbody2D rb2D;

    // Use this for initialization
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        rb2D.transform.Translate(transform.up * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  Instantiate(explosion, transform.position, transform.rotation);

        if(collision.tag == "Player")
            collision.GetComponent<PlayerState>().getDmg(DMG);


        Destroy(gameObject);
    }
}

