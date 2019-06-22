using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    public GameObject key;

    [HideInInspector]
    public bool keyBool = false;


    public GameObject lockGameObject;
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

            Destroy(lockGameObject);
            Destroy(gameObject);
        }
    }
}
