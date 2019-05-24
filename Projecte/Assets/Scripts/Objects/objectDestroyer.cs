using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDestroyer : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}


    public void Smash()
    {
       anim.SetBool("smash", true);
       Destroy(gameObject, .3f);
    }
   
       
    
}
