using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpMap : MonoBehaviour {

    public Image mapIcon;
    public GameObject gameManager;
	// Use this for initialization
	void Start ()
    {
        mapIcon.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            mapIcon.enabled = true;
            gameManager.GetComponent<LoadMap>().pickUpMap = true;

            Destroy(gameObject);
        }
    }

}
