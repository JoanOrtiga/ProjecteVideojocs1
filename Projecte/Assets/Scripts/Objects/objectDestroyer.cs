using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tumbDestroyer : MonoBehaviour
{
   

    // Use this for initialization
    void Start()
    {
      
    }


    public void Smash()
    {
       
        Destroy(gameObject.transform.parent.gameObject);
       
    }
}

