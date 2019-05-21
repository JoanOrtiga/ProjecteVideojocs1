using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TrailRenderer))]
[RequireComponent(typeof(PlayerController))]

public class PlayerFlash : PlayerController
{
    private Color saveShadowColor;

    public float speedFlash = 10f;
    public float forceFlash = 100f;

    public float flashTime = 10f;
    private bool flash;

    public Image dashON;


    

    void Start()
    {
        currentState = PlayerStates.idle;

        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        flash = true;
        sprPlayer.color = new Color(1, 1, 1, 0.1f);
        saveShadowColor = sprShadow.color;
        sprShadow.color = new Color(1, 1, 1, 0);

        GetComponent<TrailRenderer>().emitting = true;


        StartCoroutine(DeFlashPlayer());
    }

    // Update is called once per frame
    void Update()
    {


        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        sprShadow.sprite = sprPlayer.sprite;

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
    }

    private void FixedUpdate()
    {
        rb2D.AddForce(new Vector2(h, v) * forceFlash);
        rb2D.velocity = new Vector2(h, v) * Mathf.Clamp(rb2D.velocity.magnitude, -speedFlash, speedFlash);
    }

    IEnumerator DeFlashPlayer()
    {
        yield return new WaitForSeconds(flashTime * 0.333f);
        sprPlayer.color = new Color(1, 1, 1, 0.5f);

        yield return new WaitForSeconds(flashTime * 0.333f);
        sprShadow.color = saveShadowColor;

        yield return new WaitForSeconds(flashTime * 0.333f);
        sprPlayer.color = new Color(1, 1, 1, 1f);

        dashON.enabled = false;
        flash = false;

    }


    private void LateUpdate()
    {
        if (!flash)
        {
            GetComponent<TrailRenderer>().emitting = false;
            GetComponent<PlayerController>().enabled = true;
            dashON.enabled = true;
            this.enabled = false;
        }
    }
}
