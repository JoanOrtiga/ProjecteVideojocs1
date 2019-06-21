using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDestroyer : MonoBehaviour
{
    public AudioClip audioDestroy;
    public AudioSource destroyAudioSource;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        destroyAudioSource.clip = audioDestroy;
        anim = GetComponentInParent<Animator>();
    }


    public void Smash()
    {
        anim.SetBool("smash", true);
        destroyAudioSource.Play();
        Destroy(gameObject.transform.parent.gameObject, .3f);
        //Destroy(gameObject, .3f);
    }
}

