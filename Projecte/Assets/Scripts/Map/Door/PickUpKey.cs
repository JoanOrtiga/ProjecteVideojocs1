using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{

    public AudioClip audioClipKey;
    public AudioSource audioSourceKey;

    [HideInInspector]
    public bool pickUpKey = false;

    
    public Renderer keyRenderer;
  


    // Use this for initialization
    void Start()
    {
        audioSourceKey.clip = audioClipKey;


        keyRenderer = GetComponent<Renderer>();
        keyRenderer.enabled = true;

        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioSourceKey.Play();
            pickUpKey = true;
            
            keyRenderer.enabled = false;
            Destroy(gameObject, 0.8f);
           
        }
    }
}
