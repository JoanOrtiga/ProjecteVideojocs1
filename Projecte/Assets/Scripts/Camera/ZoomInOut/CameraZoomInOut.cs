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

    float size;

    private void Start()
    {
        normalZoom = Camera.main.orthographicSize;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (zoomY)
            size = GetComponent<Collider2D>().bounds.size.y;
        else if (zoomX)
            size = GetComponent<Collider2D>().bounds.size.x;
    }

    private void OnTriggerExit2D(Collider2D collision)
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (zoomY)
            YZoom(collision);
        else if (zoomX)
            XZoom(collision);
    }



    /*
     * 
     * ESTO ESTA WORK IN PROGRES. NUESTRA INTENCIÓN ES QUE SEGUN LA POSICIÓN DEL PLAYER DENTRO DEL TRIGGER, LA CAMARA TENGA UN ZOOM O OTRO.
     * DEMOMENTO LO HEMOS HECHO FUNCIONAR A MEDIAS.
     * 
     */


    private void YZoom(Collider2D collision)
    {
        float interpolation_value;

        if (Input.GetAxis("Vertical") > 0 && leftToRight_Or_DownToUp || Input.GetAxis("Vertical") < 0 && !leftToRight_Or_DownToUp)
        {
            //interpolation_value = Mathf.Max(0, ((collision.transform.position.y - transform.position.y + size) / (transform.position.y - transform.position.y + size)) * (interpolationRange - 0) + 0);

            interpolation_value = (Input.GetAxis("Vertical")) * 5f;

            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, zoomOut, Time.deltaTime * interpolation_value);
        }
        else if (Input.GetAxis("Vertical") < 0 && leftToRight_Or_DownToUp || Input.GetAxis("Vertical") > 0 && !leftToRight_Or_DownToUp) 
        {
            //interpolation_value = (((collision.transform.position.y - transform.position.y) / (transform.position.y + size - transform.position.y)) * (interpolationRange - 0) + 0) * -1;

            interpolation_value = (Input.GetAxis("Vertical") * -1) * 5f;

            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, normalZoom, Time.deltaTime * interpolation_value);
        }
    }

    private void XZoom(Collider2D collision)
    {
        float interpolation_value;

        if (Input.GetAxis("Horizontal") < 0 && leftToRight_Or_DownToUp || Input.GetAxis("Horizontal") < 0 && !leftToRight_Or_DownToUp)
        {
            //  interpolation_value = ((collision.transform.position.x - transform.position.x + size) / (transform.position.x - transform.position.x + size)) * (interpolationRange - 0) + 0;

            interpolation_value = (Input.GetAxis("Horizontal") * -1)  * 5f;

            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, zoomOut, Time.deltaTime * interpolation_value);
        }
        else if (Input.GetAxis("Horizontal") > 0 && leftToRight_Or_DownToUp || Input.GetAxis("Horizontal") > 0 && !leftToRight_Or_DownToUp)
        {
            //   interpolation_value = (((collision.transform.position.x - transform.position.x) / (transform.position.x + size - transform.position.x)) * (interpolationRange - 0) + 0) * -1;

            interpolation_value = (Input.GetAxis("Horizontal")) * 5f;

            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, normalZoom, Time.deltaTime * interpolation_value);
        }
    }
}

