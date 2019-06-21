using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbowTrap : MonoBehaviour
{

    public AudioClip ArrowSound;
    public AudioSource CrossbowAudioSource;


    public GameObject Arrow;
    public Transform spawnArrowPos;

  //  public float timeBetweenShoot = 100;
    private bool OneTimeEnter = false;

    private void Start()
    {
        CrossbowAudioSource.clip = ArrowSound;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && OneTimeEnter == false)
        {
            OneTimeEnter = true;

            InvokeRepeating("Shoot", 0, 2);
        }
       
    }

    


    private void Shoot()
    {
      
        Instantiate(Arrow, spawnArrowPos.position, transform.rotation);
        CrossbowAudioSource.Play();
    }
}
