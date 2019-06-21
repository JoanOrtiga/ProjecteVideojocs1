using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDestroyer : MonoBehaviour
{
    public AudioClip destroyClip;
    public AudioSource destroyAudioSource;
    private Animator anim;

    public bool isThisATumb = false;

    // Use this for initialization
    void Start()
    {
        destroyAudioSource.clip = destroyClip;

        if (isThisATumb)
        {
            anim = GetComponentInParent<Animator>();
        }
       
    }


    public void Smash()
    {
        if (isThisATumb)
            anim.SetBool("smash", true);

        destroyAudioSource.Play();
        Destroy(gameObject.transform.parent.gameObject, .3f);
        //Destroy(gameObject, .3f);
    }
}

