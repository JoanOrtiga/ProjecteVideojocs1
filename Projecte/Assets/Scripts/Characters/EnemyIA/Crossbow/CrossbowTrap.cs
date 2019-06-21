using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbowTrap : MonoBehaviour
{

    public AudioClip ArrowSound;
    public AudioSource CrossbowAudioSource;
    public float timeToShoot = 3;

    private float actualTIme;
    public GameObject Arrow;
    public Transform spawnArrowPos;

    private bool inTigger;

    private void Start()
    {
        inTigger = false;
        actualTIme = 2;
        CrossbowAudioSource.clip = ArrowSound;
    }


    private void Update()
    {
        Debug.Log(inTigger);
        actualTIme = actualTIme + Time.deltaTime ;

        if (actualTIme >= timeToShoot && inTigger)
        {
            actualTIme = 0;
            Shoot();
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inTigger = true;
            //  InvokeRepeating("Shoot", 0, 2);
        }
        
    }
    

    private void Shoot()
    {
      
        Instantiate(Arrow, spawnArrowPos.position, transform.rotation);
        CrossbowAudioSource.Play();
    }
}
