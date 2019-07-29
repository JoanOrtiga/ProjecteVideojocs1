using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{

    public AudioClip audioClip;
    public AudioSource audioSource;

    [HideInInspector]
    public bool pickUpKey = false;


    public Renderer keyRenderer;
  


    // Use this for initialization
    void Start()
    {
        audioSource.clip = audioClip;

        keyRenderer = GetComponent<Renderer>();
        keyRenderer.enabled = true;
        
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Play();

            pickUpKey = true;
            
            keyRenderer.enabled = false;
            Destroy(gameObject, 0.8f);
           
        }
    }
}
