using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relick2Pickup : MonoBehaviour {

    public AudioClip PickUpSound;
    private AudioSource source;
    // Use this for initialization
    void Start ()
    {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayPickupRelicInvetory>().relic2 = true;
            Destroy(gameObject);

            source.PlayOneShot(PickUpSound);
        }
    }
}
