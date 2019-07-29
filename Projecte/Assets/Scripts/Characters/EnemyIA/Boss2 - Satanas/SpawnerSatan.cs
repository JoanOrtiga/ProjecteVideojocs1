using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSatan : MonoBehaviour {

    public GameObject boss;
    public GameObject firePlatforms;
    public Vector2 position;

    public AudioClip audioClip;
    public AudioSource audioSource;


    private void Start()
    {
        audioSource.clip = audioClip;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")  
        {
            audioSource.Play();

            Instantiate(firePlatforms, new Vector2(0, 0), collision.transform.rotation);
            Instantiate(boss, position, collision.transform.rotation); 
        }
    }
}
