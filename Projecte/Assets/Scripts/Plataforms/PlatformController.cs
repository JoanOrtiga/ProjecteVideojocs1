using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{

    public float speed = 1f;

    private Transform p1, p2, currentP;
    private bool active = false;

    // Use this for initialization
    void Start()
    {
        p1 = transform.Find("P1");
        p2 = transform.Find("P2");

        p1.parent = null;
        p2.parent = null;

        currentP = p1;

    }

    // Update is called once per frame
    void Update()
    {
        if (!active)
            return;


        transform.position = Vector3.MoveTowards(transform.position, currentP.position, speed * Time.deltaTime);

        float dist = (transform.position - currentP.position).sqrMagnitude;
        if (dist < Mathf.Epsilon)
        {
            currentP = (currentP == p1 ? p2 : p1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("Active", 0.5f);
            collision.gameObject.transform.parent = transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CancelInvoke();
            active = false;
            collision.gameObject.transform.parent = null;
        }
    }

    private void Active()
    {
        active = true;
    }
}
