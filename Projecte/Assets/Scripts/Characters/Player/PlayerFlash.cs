using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerController))]
public class PlayerFlash : PlayerState
{
    [HideInInspector] public bool flash;

    private void OnEnable()
    {
        currentState = PlayerStates.flash;
        flash = true;
        sprPlayer.color = new Color(1, 1, 1, 0.1f);

        StartCoroutine(DeFlashPlayer());
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.paused)
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
        }

     

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
    }

    private void FixedUpdate()
    {
        rb2D.AddForce(new Vector2(h, v) * playerModel.forceFlash);
        rb2D.velocity = new Vector2(h, v) * Mathf.Clamp(rb2D.velocity.magnitude, -playerModel.speedFlash, playerModel.speedFlash);
    }

    IEnumerator DeFlashPlayer()
    {
        yield return new WaitForSeconds(playerModel.flashTime * 0.333f);
        sprPlayer.color = new Color(1, 1, 1, 0.5f);

        yield return new WaitForSeconds(playerModel.flashTime * 0.333f);

        yield return new WaitForSeconds(playerModel.flashTime * 0.333f);
        sprPlayer.color = new Color(1, 1, 1, 1f);

        flash = false;
    }


    private void LateUpdate()
    {
        if (!flash)
        {
            GetComponent<PlayerController>().enabled = true;
            this.enabled = false;
        }
    }
}
