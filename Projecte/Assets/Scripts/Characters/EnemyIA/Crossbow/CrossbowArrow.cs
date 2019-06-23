using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbowArrow : MonoBehaviour
{

    public float durationTime = 3f;

    public float DMG;
    public float speed;

    private void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime; 
    }

    private void OnEnable()
    {
        StartCoroutine(destroyArrow());
    }

    private IEnumerator destroyArrow()
    {
        yield return new WaitForSeconds(durationTime);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerState>().getDmg(DMG);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerState>().getDmg(DMG);
            Destroy(gameObject);
        }
    }


}
