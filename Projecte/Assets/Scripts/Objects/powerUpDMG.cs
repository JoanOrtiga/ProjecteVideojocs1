using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpDMG : PlayerState {


    public AudioClip audioClip;
    public AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
           // GameManager.instance.featherDmg = playerModel.featherPowered;
            Destroy(gameObject, 0.2f);
        }
    }
}
