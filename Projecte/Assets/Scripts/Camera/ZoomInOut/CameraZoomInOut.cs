using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomInOut : MonoBehaviour {

    public bool zoomX;
    public bool zoomY;

    public bool leftToRight_Or_DownToUp = true;

    public float zoomOut = 10f;
    public float interpolationRange = 7f;

    private float normalZoom =  10f;

    private void Start()
    {
        normalZoom = Camera.main.orthographicSize;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (zoomY)
            {
                if (Input.GetAxis("Vertical") < 0 && leftToRight_Or_DownToUp || Input.GetAxis("Vertical") > 0 && !leftToRight_Or_DownToUp)
                    Camera.main.orthographicSize = normalZoom;
                else if (Input.GetAxis("Vertical") > 0 && leftToRight_Or_DownToUp || Input.GetAxis("Vertical") < 0 && !leftToRight_Or_DownToUp)
                    Camera.main.orthographicSize = zoomOut;
            }
            else if (zoomX)
            {
                if (Input.GetAxis("Horizontal") < 0 && leftToRight_Or_DownToUp || Input.GetAxis("Horizontal") > 0 && !leftToRight_Or_DownToUp)
                    Camera.main.orthographicSize = normalZoom;
                else if (Input.GetAxis("Horizontal") > 0 && leftToRight_Or_DownToUp || Input.GetAxis("Horizontal") < 0 && !leftToRight_Or_DownToUp)
                    Camera.main.orthographicSize = zoomOut;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (zoomY)
                YZoom(collision);
            else if (zoomX)
                XZoom(collision);
        }
    }

    private void YZoom(Collider2D collision)
    {
        float interpolation_value;

        if (leftToRight_Or_DownToUp)
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                interpolation_value = (Input.GetAxis("Vertical")) * 5f;

                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, zoomOut, Time.deltaTime * interpolation_value);
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                interpolation_value = (Input.GetAxis("Vertical") * -1) * 5f;

                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, normalZoom, Time.deltaTime * interpolation_value);
            }
        }
        else
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                interpolation_value = (Input.GetAxis("Vertical")) * 5f;

                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, normalZoom, Time.deltaTime * interpolation_value);
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                interpolation_value = (Input.GetAxis("Vertical") * -1) * 5f;

                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, zoomOut, Time.deltaTime * interpolation_value);
            }
        }
        
    }

    private void XZoom(Collider2D collision)
    {
        float interpolation_value;

        if (leftToRight_Or_DownToUp)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                interpolation_value = (Input.GetAxis("Horizontal")) * 5f;

                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, zoomOut, Time.deltaTime * interpolation_value);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                interpolation_value = (Input.GetAxis("Horizontal") * -1) * 5f;

                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, normalZoom, Time.deltaTime * interpolation_value);
            }
        }
        else
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                interpolation_value = (Input.GetAxis("Horizontal")) * 5f;

                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, normalZoom, Time.deltaTime * interpolation_value);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                interpolation_value = (Input.GetAxis("Horizontal") * -1) * 5f;

                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, zoomOut, Time.deltaTime * interpolation_value);
            }
        }

    }
}

