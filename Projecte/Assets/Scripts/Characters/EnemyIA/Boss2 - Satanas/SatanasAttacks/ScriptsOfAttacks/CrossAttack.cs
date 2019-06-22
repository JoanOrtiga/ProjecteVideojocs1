using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAttack : MonoBehaviour {

    Rigidbody2D rb2d;
    private float timeToFinish;
    private float rotSpeed;

    private bool damagable;

    public enum RotationState
    {
        min, max, during, end
    }

    RotationState state;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        GetComponent<Collider2D>().enabled = false;

    }

    private void Start()
    {
        rb2d.rotation = 0;
    }

    private void OnEnable()
    {
        rb2d.rotation = 0;
        state = RotationState.min;
        rotSpeed = GameManager.instance.satanModel.rotationSpeedMin;
        timeToFinish = GameManager.instance.satanModel.timeRotating;
        GetComponent<Collider2D>().enabled = false;
    }

    private void FixedUpdate()
    {
        if(state == RotationState.min)
        {
            rotSpeed = Mathf.Lerp(rotSpeed, GameManager.instance.satanModel.rotationSpeedMax, GameManager.instance.satanModel.lerpRotationSpeed);

            if(rb2d.transform.rotation.z >= 0.13f)
            {
                GetComponent<Collider2D>().enabled = true;
            }

            rb2d.transform.Rotate(Vector3.forward * rotSpeed * Time.fixedDeltaTime);

            timeToFinish -= Time.fixedDeltaTime;

            if (timeToFinish <= 0)
                state = RotationState.end;
        }
        else if(state == RotationState.end)
        {
            rotSpeed = Mathf.Lerp(rotSpeed, GameManager.instance.satanModel.rotationSpeedMin, GameManager.instance.satanModel.lerpRotationSpeed);
            rb2d.transform.Rotate(Vector3.forward * rotSpeed * Time.fixedDeltaTime);

            if (rotSpeed <= 20)
                this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && damagable == true)
        {
            collision.GetComponent<PlayerState>().getDmg(GameManager.instance.satanModel.crossDmgAttack);
            damagable = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            damagable = true;
        }
    }
}
