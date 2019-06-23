using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour {

    public GameObject crossHairSprite;
    private Vector3 mausePosition;

    private void Start()
    {
      //  Cursor.visible = false;
    }



    // Update is called once per frame
    void Update ()
    {
       // Cursor.visible = false;
        mausePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mausePosition.z = 0;

        crossHairSprite.GetComponent<Transform>().position = mausePosition;
    }
}
