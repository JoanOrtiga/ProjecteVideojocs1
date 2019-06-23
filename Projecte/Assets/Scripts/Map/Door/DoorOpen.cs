using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    public GameObject key;
    public GameObject lockGameObject;
  

    [HideInInspector]
    public bool keyBool = false;


   
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
