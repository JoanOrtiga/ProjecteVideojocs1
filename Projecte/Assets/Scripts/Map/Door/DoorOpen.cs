using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {


    public bool key = false;
    public GameObject lockGameObject;
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && key)
        {

            Destroy(lockGameObject);
            Destroy(gameObject);
        }
    }
}
