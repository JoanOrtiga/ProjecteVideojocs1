using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        audioSource.clip = audioClip;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
            Destroy(gameObject, 0.8f);
            //posar true al script de doorOpen;
        }
    }
}
