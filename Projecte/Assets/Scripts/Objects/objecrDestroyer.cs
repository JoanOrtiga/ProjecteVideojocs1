using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objecrDestroyer : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Smash()
    {
       anim.SetBool("smash", true);
       Destroy(gameObject, .3f);
     //   StartCoroutine(breakCo());
        
    }
    IEnumerable breakCo()
    {
        yield return new WaitForSeconds(.3f);
        this.gameObject.SetActive(false);
    }
       
    
}
