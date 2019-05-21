using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerStates
{
    attack, walk, idle, flash
}

public class PlayerController : PlayerState
{

    [Range(0.1f, 20)] public float speed = 4f;
    [Range(0.1f, 100)] public float force = 70f;
    [Range(0.1f, 100)] public float TimeBetweenFlash = 3;


    protected Animator animator;
    public PlayerStates currentState;

    protected float timeForFlash = 5;
    protected float h, v;

    // Start is called before the first frame update
    void Start()
    {
        currentState = PlayerStates.idle;
     
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timeForFlash  = Time.deltaTime + timeForFlash;
        

        if (currentState != PlayerStates.attack)
        {
            v = Input.GetAxis("Vertical");
            h = Input.GetAxis("Horizontal");
        }
        else
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

        }
        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("attacking", false);
            currentState = PlayerStates.idle;

        }
    }



    private void FixedUpdate()
    {

        rb2D.AddForce(new Vector2(h, v) * force);
        rb2D.velocity = new Vector2(h, v) * Mathf.Clamp(rb2D.velocity.magnitude, -speed, speed);


    }

    private void LateUpdate()
    {
        if (Input.GetButtonDown("Fire2") && timeForFlash >= TimeBetweenFlash)
        {
            timeForFlash = 0;
            GetComponent<PlayerFlash>().enabled = true;
            this.enabled = false;

        }
    }
}
