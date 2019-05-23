using UnityEngine;
using System.Collections;

public class FireBallScript : MonoBehaviour
{
    Vector2 playerPosition;
    Rigidbody2D rb2d;

    private float speed = 20f;

    // Use this for initialization
    void Start()
    {
        playerPosition = (Vector2)GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().transform.position - (Vector2)transform.position;
        playerPosition.Normalize();
        rb2d = GetComponent<Rigidbody2D>();
        
   
        transform.Rotate(0.0f, 0.0f, Mathf.Atan2(playerPosition.y, playerPosition.x) * Mathf.Rad2Deg);
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.AddForce(playerPosition * speed, ForceMode2D.Impulse);
        rb2d.velocity = playerPosition * speed;
       
        Destroy(this.gameObject, 2.5f);
    }
}
