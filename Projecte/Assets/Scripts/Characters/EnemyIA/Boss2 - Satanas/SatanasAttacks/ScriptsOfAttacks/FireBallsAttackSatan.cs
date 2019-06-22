using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallsAttackSatan : MonoBehaviour {

    Vector2 playerPosition;
    Rigidbody2D rb2d;

    void Start()
    {
        playerPosition = (Vector2)GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().transform.position - (Vector2)transform.position;
        playerPosition.Normalize();
        rb2d = GetComponent<Rigidbody2D>();

        transform.Rotate(0.0f, 0.0f, Mathf.Atan2(playerPosition.y, playerPosition.x) * Mathf.Rad2Deg);
    }

    void Update()
    {
        rb2d.AddForce(playerPosition * GameManager.instance.satanModel.fireBallSpeed, ForceMode2D.Impulse);
        rb2d.velocity = playerPosition * GameManager.instance.satanModel.fireBallSpeed;

        Destroy(this.gameObject, GameManager.instance.satanModel.timeToDestroy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerState>().getDmg(GameManager.instance.satanModel.fireBallDmg);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Player")
            Destroy(gameObject);
    }


}
