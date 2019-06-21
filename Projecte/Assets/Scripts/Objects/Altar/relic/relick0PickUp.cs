using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relick0PickUp : MonoBehaviour {


    public AudioClip PickUpSound;
    public AudioSource RelicAudioSoure;

    // Use this for initialization
    void Start ()
    {

        RelicAudioSoure.clip = PickUpSound;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayPickupRelicInvetory>().relic_grail = true;
            RelicAudioSoure.Play();
            Destroy(gameObject, 0.1f);
        }
    }
}
