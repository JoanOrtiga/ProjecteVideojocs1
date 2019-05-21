using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeEffect : MonoBehaviour {

    private float shakeDuration = 2f;

    private float shakeMagnitude = 0.7f;

    private float dampingSpeed = 1.0f;

    Vector3 initialPosition;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        shakeDuration = 2f;
        initialPosition = Camera.main.transform.localPosition;
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (shakeDuration > 0)
        {
            Camera.main.transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            shakeDuration = 0f;
            Camera.main.transform.localPosition = initialPosition;
        }
    }

}
