using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    public AudioClip audioClip;
    public AudioSource audioSource;

    public GameObject key;
    public GameObject lockGameObject;
  

    [HideInInspector]
    public bool keyBool = false;

    private void Start()
    {
        audioSource.clip = audioClip;
    }

    // Use this for initialization
    private void Update()
    {
        if (key !=null)
        {
            keyBool = key.GetComponent<PickUpKey>().pickUpKey;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && keyBool)
        {
            audioSource.Play();

            Destroy(lockGameObject, 0.3f);
            
           
            Destroy(gameObject, 0.3f);
        }
    }
}
