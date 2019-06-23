using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpMap : MonoBehaviour {


    public Renderer rendererGameObject;

    public AudioClip audioClipKey;
    public AudioSource audioSourceKey;

    public Image mapIcon;
    public GameObject gameManager;
	// Use this for initialization
	void Start ()
    {
        rendererGameObject = GetComponent<Renderer>();
        rendererGameObject.enabled = true;

        audioSourceKey.clip = audioClipKey;
        mapIcon.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioSourceKey.Play();
            mapIcon.enabled = true;
            rendererGameObject.enabled = false;
            gameManager.GetComponent<LoadMap>().pickUpMap = true;

            Destroy(gameObject, 0.7f);
        }
    }

}
