using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbowTrap : MonoBehaviour
{

    public AudioClip ArrowSound;
    public AudioSource CrossbowAudioSource;

    private float actualTIme;
    public GameObject Arrow;
    public Transform spawnArrowPos;
    public float timeForArrows = 2;

    private bool oneTime = false;

    private void Start()
    {

        CrossbowAudioSource.clip = ArrowSound;
    }


  



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && oneTime == false)
        {
            oneTime = true;
              InvokeRepeating("Shoot", 0, timeForArrows);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            CancelInvoke("Shoot");
            oneTime = false;
        }
    }
    private void Shoot()
    {
      
        Instantiate(Arrow, spawnArrowPos.position, transform.rotation);
        CrossbowAudioSource.Play();
    }
}
