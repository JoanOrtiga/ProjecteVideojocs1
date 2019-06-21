using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDestroyer : MonoBehaviour
{
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponentInParent<Animator>();
    }


    public void Smash()
    {
        anim.SetBool("smash", true);
        Destroy(gameObject.transform.parent.gameObject, .3f);
        //Destroy(gameObject, .3f);
    }
}

