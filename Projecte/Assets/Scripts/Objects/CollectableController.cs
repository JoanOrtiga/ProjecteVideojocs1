using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;


    public Item item;
    public int quantity = 1;

    // Use this for initialization
    void Start()
    {
        audioSource.clip = audioClip;
        GetComponent<SpriteRenderer>().sprite = item.displayImage;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.Play();
            GameManager.instance.getPlayerInv().Add(item, quantity);
            Destroy(gameObject,0.2f);
        }
    }

    private void OnDrawGizmos()
    {
        GetComponent<SpriteRenderer>().sprite = item.displayImage;
    }
}

