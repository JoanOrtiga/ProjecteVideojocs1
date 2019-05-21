using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCamera : MonoBehaviour {

    Collider2D myCollider;

    GameObject varGameObject;

    [Range(0f, 1f)] public float interpolation = 0.05f;

	// Use this for initialization
	void Start ()
    {
        myCollider = GetComponent<Collider2D>();

        varGameObject = GameObject.FindWithTag("MainCamera");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        varGameObject.GetComponent<CameraDeathZoneController>().enabled = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(myCollider.transform.position.x, myCollider.transform.position.y, Camera.main.transform.position.z), interpolation);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        varGameObject.GetComponent<CameraDeathZoneController>().enabled = true;
    }
}
