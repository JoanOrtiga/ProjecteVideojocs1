using UnityEngine;
using System.Collections;

public class FireBallScript : MonoBehaviour
{
    Vector2 playerPosition;
    Rigidbody2D rb2d;

    private float speed = 20f;

    void Start()
    {
        playerPosition = (Vector2)GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().transform.position - (Vector2)transform.position;
        playerPosition.Normalize();
        rb2d = GetComponent<Rigidbody2D>();
        
        transform.Rotate(0.0f, 0.0f, Mathf.Atan2(playerPosition.y, playerPosition.x) * Mathf.Rad2Deg);
    }

    void Update()
    {
        rb2d.AddForce(playerPosition * speed, ForceMode2D.Impulse);
        rb2d.velocity = playerPosition * speed;
       
        Destroy(this.gameObject, 2.2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<PlayerState>().getDmg(GameManager.instance.boss1_model.attackFireBallDmg);
            Destroy(gameObject);
        }
    }
}
