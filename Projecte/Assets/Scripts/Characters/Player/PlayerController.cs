﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : PlayerState
{
    public AudioClip attackSound;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        currentState = PlayerStates.idle;
        source = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        currentState = PlayerStates.idle;
    }

    // Update is called once per frame
    void Update()
    {
        playerModel.timeForFlash = Time.deltaTime + playerModel.timeForFlash;

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if (currentState == PlayerStates.attack)
        {
            v = 0;
            h = 0;
        }

        if (h != 0 || v != 0)
        {
            animator.SetFloat("moveX", h);
            animator.SetFloat("moveY", v);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }

        if (Input.GetButtonDown("Fire1") && currentState != PlayerStates.attack)
        {
            animator.SetBool("attacking", true);
            currentState = PlayerStates.attack;
            source.PlayOneShot(attackSound);

        }
        if (!(Input.GetButtonDown("Fire1")))
        {
            animator.SetBool("attacking", false);
            currentState = PlayerStates.idle;
        }
    }

    private void FixedUpdate()
    {
        rb2D.AddForce(new Vector2(h, v) * playerModel.force);
        rb2D.velocity = new Vector2(h, v) * Mathf.Clamp(rb2D.velocity.magnitude, -playerModel.speed, playerModel.speed);
    }

    private void LateUpdate()
    {
        if (Input.GetButtonDown("Fire2") && playerModel.timeForFlash >= playerModel.TimeBetweenFlash)
        {
            playerModel.timeForFlash = 0;
            GetComponent<PlayerFlash>().enabled = true;
            this.enabled = false;

        }
    }
}
