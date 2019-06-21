using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudBall_SwampMan : MonoBehaviour {

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
        rb2d.AddForce(playerPosition * GameManager.instance.swampManModel.ballSpeed, ForceMode2D.Impulse);
        rb2d.velocity = playerPosition * GameManager.instance.swampManModel.ballSpeed;

        Destroy(this.gameObject, GameManager.instance.swampManModel.timeToDestroy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<PlayerState>().getDmg(GameManager.instance.swampManModel.attackBallMud);
            Destroy(gameObject);
        }
    } 
}
